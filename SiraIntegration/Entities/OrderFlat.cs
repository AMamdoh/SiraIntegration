using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Entities
{


    public class OrderFlat
    {
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public string orderNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal totalOrderPrice { get; set; }
        public string itemName { get; set; }
        public int itemQuantity { get; set; }
        public decimal itemPrice { get; set; }
        public string locationCode { get; set; }
        public string channel { get; set; }
    }
}
        

    

