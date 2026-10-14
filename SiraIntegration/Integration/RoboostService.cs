using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SiraIntegration.Entities;
using SiraIntegration.Entities.Logger;
using SiraIntegration.Helpers;
using SiraIntegration.Helpers.ViewModels;
using SiraIntegration.Integration;
using SiraIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace SiraIntegration.Integration
{
    public static class RoboostService
    {
        private static readonly string _baseUrl;
        private static readonly string _token;
        private static readonly string _companyId;

        private static readonly string _createUrl;

        private static readonly string tableName;

        static RoboostService()
        {
            var settings = INIHelper.LoadAPISettings();
            var databaseSettings = INIHelper.LoadDatabaseSettings();

            tableName = databaseSettings.SiraOrderTable?? "Sira_Log";

            _baseUrl = settings.Url.TrimEnd('/');
            _token = settings.Token;
            _companyId = settings.CompanyId?.Trim();

            _createUrl = $"{_baseUrl}/POS/CreateOrder";

        }

        private static readonly HttpClient client = new HttpClient();

        public static async Task<bool> SendSiraOrderAsync(SiraCreateOrderDto siraOrder, ILogger logger, UiLogger memoryLogger)
        {
            logger.LogInformation("Processing Sira order {OrderNumber}...", siraOrder.OrderNumber);
            memoryLogger.LogInfo($"Sending Sira order {siraOrder.OrderNumber}...");

            try
            {
                string trimmedToken = _token.Trim();

                var jsonPayload = JsonConvert.SerializeObject(siraOrder);

                var request = new HttpRequestMessage(HttpMethod.Post, _createUrl)
                {
                    Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json")
                };

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", trimmedToken);
                request.Headers.UserAgent.ParseAdd("SiraIntegration/1.0");

                if (!string.IsNullOrWhiteSpace(_companyId))
                {
                    request.Headers.Add("x-company-id", _companyId);
                }
                else
                {
                    logger.LogWarning("CompanyId is missing from the [API] section of the configuration file. Sira will reject the request with 401 Unauthorized.");
                    memoryLogger.LogError("CompanyId is not configured. Add CompanyId under [API] in the configuration file.");
                }

                var sentTime = DateTime.Now;
                var response = await client.SendAsync(request);
                var responseTime = DateTime.Now;
                var responseContent = await response.Content.ReadAsStringAsync();

                int statusCode = (int)response.StatusCode;

                // Always keep the raw response, prefixed with the status code, so failures are visible in the log table.
                string rawResponse = $"HTTP {statusCode} {response.ReasonPhrase}{Environment.NewLine}{responseContent}";

                bool isSuccess = false;
                string apiMessage = null;

                if (!string.IsNullOrWhiteSpace(responseContent))
                {
                    try
                    {
                        var siraResponse = JsonConvert.DeserializeObject<SiraResponse>(responseContent);
                        isSuccess = siraResponse?.IsSuccess ?? false;
                        apiMessage = siraResponse?.Message;
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "Failed to deserialize response for Sira order {OrderNumber}. HTTP {StatusCode}. Raw Response: {RawResponse}", siraOrder.OrderNumber, statusCode, responseContent);
                        apiMessage = $"Unexpected response body: {Truncate(responseContent, 500)}";
                    }
                }

                if (string.IsNullOrWhiteSpace(apiMessage))
                {
                    apiMessage = DescribeStatus(statusCode, responseContent);
                }

                var orderLog = new Sira_Log
                {
                    ReferenceID = siraOrder.OrderNumber,
                    SentTime = sentTime,
                    ResponseTime = responseTime,
                    Payload = jsonPayload,
                    Response = rawResponse,
                    IsSuccess = isSuccess,
                    LastUpdated = DateTime.Now,

                };
                SaveSiraOrderLog(orderLog, logger);

                if (isSuccess)
                {
                    logger.LogInformation("Sira order {OrderNumber} dispatched successfully. HTTP {StatusCode}. API Message: {ApiMessage}", siraOrder.OrderNumber, statusCode, apiMessage);
                    memoryLogger.LogInfo($"Sira order {siraOrder.OrderNumber} was successfully sent. (HTTP {statusCode}) {apiMessage}");
                    return true;
                }
                else
                {
                    logger.LogWarning("API reported failure for Sira order {OrderNumber}. HTTP {StatusCode}. Raw Response: {RawResponse}", siraOrder.OrderNumber, statusCode, rawResponse);
                    memoryLogger.LogError($"Failed to send Sira order {siraOrder.OrderNumber}. (HTTP {statusCode}) {apiMessage}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Exception while sending Sira order {OrderNumber}. Error: {ErrorMessage}",
                    siraOrder.OrderNumber, ex.Message);


                string fullError = ex.InnerException != null
                    ? $"{ex.Message} | Inner: {ex.InnerException.Message}"
                    : ex.Message;

                memoryLogger.LogError($"Failed to send Order {siraOrder.OrderNumber}. Reason: {fullError}");

                return false;
            }
        }


        /// <summary>Explains an empty or non-JSON response so the UI never shows a blank reason.</summary>
        private static string DescribeStatus(int statusCode, string responseContent)
        {
            bool hasBody = !string.IsNullOrWhiteSpace(responseContent);

            switch (statusCode)
            {
                case 401:
                    return "Unauthorized (401): the token is invalid/expired, or the x-company-id header is missing.";
                case 403:
                    return hasBody && responseContent.IndexOf("cloudflare", StringComparison.OrdinalIgnoreCase) >= 0
                        ? "Forbidden (403): the request was blocked by Cloudflare before reaching Sira."
                        : "Forbidden (403): this user has no access to the configured company.";
                case 400:
                    return $"Bad request (400): {Truncate(responseContent, 500)}";
                default:
                    return hasBody
                        ? $"HTTP {statusCode}: {Truncate(responseContent, 500)}"
                        : $"HTTP {statusCode}: the server returned an empty body.";
            }
        }

        private static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value) || value.Length <= maxLength)
                return value;

            return value.Substring(0, maxLength) + "...";
        }

        private static void SaveSiraOrderLog(Sira_Log orderLog, ILogger logger)
        {
     

            string sqlCheck = $@"SELECT TOP 1 Version, RetriesCount 
                             FROM {tableName}
                             WHERE ReferenceID = @ReferenceID";

            var existingLog = DapperHelper.Get<(int Version, int RetriesCount)?>(sqlCheck, new { orderLog.ReferenceID });

            if (existingLog != null)
            {
                UpdateExistingLog(orderLog, existingLog.Value, logger, tableName);
            }
            else
            {
                SaveFirstInsert(orderLog, logger, tableName);
            }
        }

        private static void UpdateExistingLog(Sira_Log orderLog, (int Version, int RetriesCount) existingLog, ILogger logger, string tableName)
        {
            orderLog.Version = existingLog.Version;
            orderLog.RetriesCount = existingLog.RetriesCount + 1;

            string updateSql = $@"UPDATE {tableName}
                              SET SentTime = @SentTime, 
                                  ResponseTime = @ResponseTime, 
                                  Response = @Response, 
                                  IsSuccess = @IsSuccess, 
                                  LastUpdated = @LastUpdated,
                                  RetriesCount = @RetriesCount,
                                  Payload = @Payload
                              WHERE ReferenceID = @ReferenceID AND Version = @Version";

            DapperHelper.Update(updateSql, orderLog);
            logger.LogInformation($"Sira log for order {orderLog.ReferenceID} was updated (Retries: {orderLog.RetriesCount}).");
        }

        private static void SaveFirstInsert(Sira_Log orderLog, ILogger logger, string tableName)
        {
            orderLog.Version = 1;
            orderLog.RetriesCount = 0;

            string firstInsertSql = $@"INSERT INTO {tableName}
                                   (ReferenceID, SentTime, ResponseTime, Payload, Response, IsSuccess, Version, RetriesCount, LastUpdated)
                                   VALUES 
                                   (@ReferenceID, @SentTime, @ResponseTime, @Payload, @Response, @IsSuccess, @Version, @RetriesCount, @LastUpdated)";

            DapperHelper.Add(firstInsertSql, orderLog);
            logger.LogInformation($"First Sira log for order {orderLog.ReferenceID} was inserted.");
        }

        internal static async Task SendReviewAsync(Sira_Log r, ILogger<FrmMain> logger)
        {
            throw new NotImplementedException();
        }
    }
}