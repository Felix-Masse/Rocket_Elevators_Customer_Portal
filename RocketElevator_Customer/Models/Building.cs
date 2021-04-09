using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketElevator_Customer.Models
{
    public class Building
    {
        public int id { get; set; }
        public string building_address { get; set; }
        public string building_admin_full_name { get; set; }
        public string building_admin_email { get; set; }
        public string building_admin_phone { get; set; }
        public string building_technical_full_name { get; set; }
        public string building_technical_email { get; set; }
        public string building_technical_phone { get; set; }
        public int address_id { get; set; }
        public int customer_id { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
    }
}


