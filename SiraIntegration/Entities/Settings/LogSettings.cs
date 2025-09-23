using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Entities
{
    public class LogSettings
    {
        public string Folder { get; set; }
        public int ClearLogInterval { get; set; }
        public string ClearLogUnit { get; set; }
    }

}
