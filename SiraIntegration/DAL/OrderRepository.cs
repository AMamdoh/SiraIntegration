using Dapper;
using Microsoft.Extensions.Logging;
using SiraIntegration.Entities;
using SiraIntegration.Entities.Logger;
using SiraIntegration.Entities.Settings;
using SiraIntegration.Helpers;
using SiraIntegration.Helpers.Settings;
using SiraIntegration.Helpers.ViewModels;
using SiraIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SiraIntegration.DAL
{
    public static class OrderRepository
    {
        private static string tableName;
        
        static OrderRepository()
        {
            var settings = INIHelper.LoadDatabaseSettings();

            tableName = settings.SiraOrderTable?? "Sira_Log";
        }

      
            public static List<SiraCreateOrderDto> MapSiraData(IEnumerable<OrderFlat> 
                flatItems)
            {
                if (flatItems == null || !flatItems.Any())
                {
                    return new List<SiraCreateOrderDto>();
                }

                return flatItems
                    .GroupBy(item => item.orderNumber)
                    .Select(orderGroup =>
                    {
                        var firstItem = orderGroup.First();

                        return new SiraCreateOrderDto
                        {
                           
                            CustomerInfo = new SiraCustomerInfoDto
                            {
                                CustomerName = firstItem.customerName,
                                CustomerPhone = firstItem.customerPhone
                            },

                            OrderNumber = firstItem.orderNumber,
                            Items = orderGroup.Select(item => new SiraOrderItemDto
                            {
                                Name = item.itemName,
                                Quantity = item.itemQuantity,
                                Prices = item.itemPrice,
                                Code = item.locationCode
                            }).ToList(),
                            Date = DateTime.SpecifyKind(firstItem.Date, DateTimeKind.Utc),

                            ChannelCode = firstItem.channel,
                            LocationCode = firstItem.locationCode,
                            Amount = firstItem.totalOrderPrice
                        };
                    })
                    .ToList();
            }
        
        public static List<SiraCreateOrderDto> GetOrdersToSend(int count, ILogger logger,UiLogger memoryLogger, DateTime? cutoff = null)
        {
            var settings = INIHelper.LoadDatabaseSettings();
            var allowedStores = INIHelper.LoadStores();


            string partialSelect = $@"
            SELECT TOP (@Count) *
            FROM [{settings.NewOrdersView}] o
            WHERE 
                (@Cutoff IS NULL OR  o.[Date] >= @Cutoff)
                AND NOT EXISTS (
                    SELECT 1 
                    FROM [{tableName}] l 
                    WHERE l.ReferenceID = o.orderNumber
                )";


            string orderBy = " ORDER BY o.[Date] DESC;";

            string sql;
            object parameters;

            bool hasStores = 
                allowedStores?.StoreCodes != null && allowedStores.StoreCodes.Count > 0;

            if (!hasStores)
            {
                sql = partialSelect + orderBy;
                parameters = new { Count = count, Cutoff = cutoff };
            }
            else
            {
                sql = partialSelect + $@"
                      AND o.StoreCode IN ('{ string.Join("','", allowedStores.StoreCodes)}')" + orderBy;

                parameters = new
                {
                    Count = count,
                    Cutoff = cutoff,
                    StoreCodes = allowedStores.StoreCodes
                };
            }

            try
            {
                var flatOrders = DapperHelper.GetList<OrderFlat>(sql, parameters);
                foreach (var order in flatOrders)
                {
                    order.Date = DateTime.SpecifyKind(order.Date, DateTimeKind.Utc);
                }
                logger.LogInformation("Found {FoundCount} new orders to process.", flatOrders.Count());
                memoryLogger.LogInfo($"Found {flatOrders.Count()} new orders.");

                var nestedOrders = MapSiraData(flatOrders);

                return nestedOrders;
            }
            catch (Exception ex)
            {
                logger.LogError(message: $"Error fetching orders: {ex.Message} \n Query: {sql}");

                memoryLogger.LogError( $"Error fetching orders: {ex.Message} \n Query: {sql}");

                return new List<SiraCreateOrderDto>();
            }
        }
       
        
        
        //public static List<OrderDto> GetReviewsToSend(int count, ILogger logger,UiLogger memoryLogger ,DateTime? cutoff = null)
        //{
        //    var settings = INIHelper.LoadDatabaseSettings();
        //    var allowedStores = INIHelper.LoadStores();


        //    string partialSelect = $@"
        //        SELECT TOP(@Count) *
        //        FROM {settings.ReviewsViewName}
        //                o
        //        WHERE(@Cutoff IS NULL OR o.[Date] >= @Cutoff)
        //          AND NOT EXISTS(SELECT 1 FROM {tableName}
        //                l2 WHERE l2.ReferenceID = o.ID)
        //    ";


        //    string orderBy = " ORDER BY o.[Date] DESC;";

        //    string sql;
        //    object parameters;

        //    bool hasStores =
        //        allowedStores?.StoreCodes != null && allowedStores.StoreCodes.Count > 0;

        //    if (!hasStores)
        //    {
        //        sql = partialSelect + orderBy;
        //        parameters = new { Count = count, Cutoff = cutoff };
        //    }
        //    else
        //    {
        //        sql = partialSelect + $@"
        //              AND o.StoreCode IN ('{string.Join("','", allowedStores.StoreCodes)}')" + orderBy;

        //        parameters = new
        //        {
        //            Count = count,
        //            Cutoff = cutoff,
        //            StoreCodes = allowedStores.StoreCodes
        //        };
        //    }

        //    try
        //    {
        //        var flatOrders = DapperHelper.GetList<OrderFlat>(sql, parameters);

        //        logger.LogInformation("Found {FoundCount} new reviews_orders to process.", flatOrders.Count());
        //        memoryLogger.LogInfo($"Found {flatOrders.Count()} new reviews_orders.");

        //        return flatOrders.Select(MapToNestedOrder).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError($"Error reviews_orders: {ex.Message} \n Query: {sql}");
        //        memoryLogger.LogError($"Error reviews_orders: {ex.Message} \n Query: {sql}");



        //        return new List<OrderDto>();
        //    }
        //}







    }


}

