using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Entity
{
    public class Booking
    {
        public string JourneyDate { get; set; }
        public string Seats { get; set; }
        public int AvailableSeatCount { get; set; }
        public string ScheduleId { get; set; }
    }
}
