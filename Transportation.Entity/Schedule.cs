using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Entity
{
    public class Schedule
    {
        public string ScheduleId { get; set; }
        public string DeptTime { get; set; }
        public string ArrivalTime { get; set; }
        public string RouteId { get; set; }
    }
}
