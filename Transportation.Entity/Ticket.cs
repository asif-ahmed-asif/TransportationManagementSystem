using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Entity
{
    public class Ticket
    {
        public string TicketId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string JourneyDate { get; set; }
        public string SeatNo { get; set; }
        public string ScheduleId { get; set; }
        public string FareId { get; set; }
    }
}
