using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Entity
{
    public class Route
    {
        public string RouteId { get; set; }
        public string DeptLocation { get; set; }
        public string Destination { get; set; }
        public string BusNo { get; set; }
        public string ScheduleId { get; set; }
        public string DeptTime { get; set; } //view model
        public string ArrivalTime { get; set; } //view model
        public string Status { get; set; }
    }
}
