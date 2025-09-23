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

        private static readonly string _createUrl;

        private static readonly string tableName;

        static RoboostService()
        {
            var settings = INIHelper.LoadAPISettings();
            var databaseSettings = INIHelper.LoadDatabaseSettings();

            tableName = databaseSettings.SiraOrderTable?? "Sira_Log";

            _baseUrl = settings.Url.TrimEnd('/');
            _token = settings.Token;

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
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", trimmedToken);

                var jsonPayload = JsonConvert.SerializeObject(siraOrder);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var sentTime = DateTime.Now;
                var response = await client.PostAsync(_createUrl, content);
                var responseTime = DateTime.Now;
                var responseContent = await response.Content.ReadAsStringAsync();

                bool isSuccess = false;
                string apiMessage = "No message returned";

                try
                {
                    var siraResponse = JsonConvert.DeserializeObject<SiraResponse>(responseContent);
                    isSuccess = siraResponse?.IsSuccess ?? false;
                    apiMessage = siraResponse?.Message ?? apiMessage;
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to deserialize response for Sira order {OrderNumber}. Raw Response: {RawResponse}", siraOrder.OrderNumber, responseContent);
                    memoryLogger.LogError($"Received an invalid response for Sira order {siraOrder.OrderNumber}.");
                    apiMessage = "Invalid response format from Sira";
                }

                var orderLog = new Sira_Log
                {
                    ReferenceID = siraOrder.OrderNumber,
                    SentTime = sentTime,
                    ResponseTime = responseTime,
                    Payload = jsonPayload,
                    Response = responseContent,
                    IsSuccess = isSuccess,
                    LastUpdated = DateTime.Now,
                    
                };
                SaveSiraOrderLog(orderLog, logger);

                if (isSuccess)
                {
                    logger.LogInformation("Sira order {OrderNumber} dispatched successfully. API Message: {ApiMessage}", siraOrder.OrderNumber, apiMessage);
                    memoryLogger.LogInfo($"Sira order {siraOrder.OrderNumber} was successfully sent.");
                    return true;
                }
                else
                {
                    logger.LogWarning("API reported failure for Sira order {OrderNumber}. API Response: {ApiResponse}", siraOrder.OrderNumber, apiMessage);
                    memoryLogger.LogError($"Failed to send Sira order {siraOrder.OrderNumber}. Reason: {apiMessage}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An unexpected exception occurred while sending Sira order {OrderNumber}.", siraOrder.OrderNumber);
                memoryLogger.LogError($"A critical error occurred sending Sira order {siraOrder.OrderNumber}. Check the file log.");


                return false;
            }
        }


        private static void SaveSiraOrderLog(Sira_Log orderLog, ILogger logger)
        {
     

            string sqlCheck = $@"SELECT TOP 1 Version, RetriesCount 
                             FROM [{tableName}] 
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

            string updateSql = $@"UPDATE [{tableName}] 
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

            string firstInsertSql = $@"INSERT INTO [{tableName}] 
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