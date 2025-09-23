using Microsoft.Extensions.Logging;
using SiraIntegration.Data.Responses;
using SiraIntegration.Entities;
using SiraIntegration.Entities.Logger;
using SiraIntegration.Helpers;
using SiraIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.DAL
{
    public class OrderLogRepository
    {
        readonly string tableName;
        public OrderLogRepository()
        {
            var settings = INIHelper.LoadDatabaseSettings();

            tableName = settings.SiraOrderTable?? "Sira_Log";
        }

        public async Task<int> ClearOldLogsAsync(ILogger logger, UiLogger memoryLogger)
        {
            logger.LogInformation("Starting the 'Clear Old Logs' maintenance task...");
            memoryLogger.LogInfo("Cleaning up old log records...");



            string sql = $@"
        DELETE FROM [{tableName}]
        WHERE SentTime IS NOT NULL
        AND SentTime < CAST(GETDATE() AS date);";

            try
            {
                int rowsAffected = await Task.Run(() => DapperHelper.Remove(sql));

                logger.LogInformation(
                    "Successfully cleared {RowsAffected} old log records from the '{TableName}' table.",
                    rowsAffected,
                    tableName);

                memoryLogger.LogInfo($"Cleanup complete. Removed {rowsAffected} old log records.");

              
                return rowsAffected;
            }
            catch (Exception ex)
            {
                logger.LogError(ex,
                    "A critical error occurred while clearing old logs from the '{TableName}' table.",
                    tableName);

                memoryLogger.LogError($"Failed to clean up old logs. Please check the file log for details.");

                return 0;
            }
        }


        public IEnumerable<CreatedOrder> GetFilteredOrders(string filter, string referenceId = "")
        {
            string query = $@"
            SELECT ReferenceID, Payload, Response, IsSuccess,RetriesCount, SentTime, ResponseTime, LastUpdated
            FROM {tableName}";




            List<string> conditions = new List<string>();
           // conditions.Add("OrderActionType = 'Created'");

            if (filter == "success orders")
                conditions.Add("IsSuccess = 1");
            else if (filter == "fail orders")
                conditions.Add("IsSuccess = 0");

            if (!string.IsNullOrWhiteSpace(referenceId))
                conditions.Add("ReferenceID LIKE @Ref");

            if (conditions.Any())
                query += " WHERE " + string.Join(" AND ", conditions);

            query += " ORDER BY SentTime ASC"; //added

            return DapperHelper.GetList<CreatedOrder>(
                query,
                new { Ref = "%" + referenceId + "%" }
            );
        }




        public Sira_Log GetOrderByReferenceId(string referenceId)
        {
            return DapperHelper.Get<Sira_Log>(
                $"SELECT * FROM {tableName} WHERE ReferenceID = @RefId",
                new { RefId = referenceId }
            );
        }
        public LastSuccessActionRow GetLastSuccessAction()
        {
            string sql = $@"
                  SELECT TOP 1 ResponseTime
            FROM [{tableName}]
            WHERE IsSuccess = 1 
            ORDER BY LastUpdated DESC;
            ";

            return DapperHelper.Get<LastSuccessActionRow>(sql);
        }

    }

 }
