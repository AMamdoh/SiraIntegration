using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraIntegration.Helpers.ViewModels
{
    public class AddressDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public string Landmark { get; set; }
        public string CustomerDoorImageURL { get; set; }
    }
}
