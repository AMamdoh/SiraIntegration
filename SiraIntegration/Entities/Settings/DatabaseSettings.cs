using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Helpers.Settings
{
    public class DatabaseSettings
    {
        public string ServerIP { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewOrdersView { get; set; }
        public string ReviewsViewName { get; set; }
        public string SiraOrderTable { get; set; }
        public decimal RemoveOldOrdersInterval { get; set; }
        public string RemoveOldOrdersUnit { get; set; }
    }

}
