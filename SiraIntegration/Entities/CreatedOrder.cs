using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Entities
{
    public class CreatedOrder
    {
        public string ReferenceID { get; set; }
        public string Payload { get; set; }
        public string Response { get; set; }
        public bool IsSuccess { get; set; }
        public int RetriesCount { get; set; }

        public DateTime? SentTime { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime LastUpdated { get; set; }

    }

}
