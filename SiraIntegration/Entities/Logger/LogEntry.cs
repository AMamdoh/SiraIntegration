using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Entities.Logger
{
    public class LogEntry
    {
        public DateTime Time { get; set; }
        public string Level { get; set; } = "";
        public string Message { get; set; } = "";
    }

}
