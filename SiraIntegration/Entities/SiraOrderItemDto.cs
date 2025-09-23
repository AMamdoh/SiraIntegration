using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Entities
{
    public class SiraOrderItemDto
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Prices { get; set; }
        public string Code { get; set; }
    }
}
