using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Models
{
   public  class Sira_Log
    {
        public string ReferenceID { get; set; }
        public DateTime SentTime { get; set; } = DateTime.Now;
        public DateTime ResponseTime { get; set; } = DateTime.Now;
        public string Payload { get; set; } = string.Empty;
        public string Response { get; set; } = string.Empty;
        public bool IsSuccess { get; set; } = true;
        public int Version { get; set; } = 0;
        public int RetriesCount { get; set; } = 0;
        public bool Canceled { get; set; } = false;

        public DateTime? LastUpdated { get; set; }= DateTime.Now;
        public bool IsRetry { get; set; } = false;
    }
    public class SiraResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
       
    }


}
