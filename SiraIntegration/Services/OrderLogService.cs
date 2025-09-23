using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SiraIntegration.DAL;
using SiraIntegration.Entities;
using SiraIntegration.Entities.Logger;
using SiraIntegration.Helpers.ViewModels;
using SiraIntegration.Integration;
using SiraIntegration.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiraIntegration.Services
{
    public class OrderLogService
    {
        private readonly OrderLogRepository _orderLogRepository;
        private readonly ILogger<OrderLogService> _logger;
        private readonly UiLogger _memoryLogger;

        public OrderLogService(ILogger<OrderLogService> logger,UiLogger uiLogger)
        {
            _logger = logger;
            _orderLogRepository = new OrderLogRepository();
            _memoryLogger =uiLogger ;
        }

        // ============== Posted (Created) ==============
        public IEnumerable<CreatedOrder> GetFilteredOrders(string filter, string referenceId = "")
        {
            return _orderLogRepository.GetFilteredOrders(filter, referenceId);
        }

        // ============== Reviews (Created) ==============
        public IEnumerable<CreatedOrder> GetFilteredReviews(string filter, string referenceId = "")
        {
            return _orderLogRepository.GetFilteredOrders(filter, referenceId);
        }
        public async Task<bool> RetryOrderAsync(string referenceId)
        {
            var orderLog = _orderLogRepository.GetOrderByReferenceId(referenceId);
            if (orderLog == null || string.IsNullOrWhiteSpace(orderLog.Payload))
                return false;

            orderLog.IsRetry = true;

            var orderDto = JsonConvert.DeserializeObject<SiraCreateOrderDto>(orderLog.Payload);

            bool success = await RoboostService.SendSiraOrderAsync(orderDto,
                _logger, _memoryLogger);

          

            return success;
        }




        // ============== Logs Cleanup ==============
        public async Task<int> ClearOldLogsAsync()
        {
            return await _orderLogRepository.ClearOldLogsAsync(_logger,_memoryLogger);
        }
    }
}
