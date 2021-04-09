using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketElevator_Customer.Models
{

    public class Intervention
    {
        public int id { get; set; }
        public int author { get; set; }
        public int customer_id { get; set; }
        public int building_id { get; set; }
        public int battery_id { get; set; }
        public int column_id { get; set; }
        public int elevator_id { get; set; }
        public object employee_id { get; set; }
        public DateTime start_date { get; set; }
        public object end_date { get; set; }
        public string result { get; set; }
        public string report { get; set; }
        public string status { get; set; }
    }

}
