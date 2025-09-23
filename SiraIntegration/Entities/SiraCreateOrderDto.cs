using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SiraIntegration.Entities
{
    public class SiraCreateOrderDto
    {
        public SiraCustomerInfoDto CustomerInfo { get; set; }
        public string OrderNumber { get; set; }
        public List<SiraOrderItemDto> Items { get; set; }


        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Date { get; set; }
        public string ChannelCode { get; set; }
        public string LocationCode { get; set; }
        public decimal Amount { get; set; }

    }
}
    
