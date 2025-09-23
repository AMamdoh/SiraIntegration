using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Helpers.ViewModels
{
    public class CustomerDto
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string WhatsAppNumber { get; set; }
        public AddressDto Address { get; set; }
    }
}
