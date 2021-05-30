using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Entity
{
    public class Bus
    {
        public string BusNo { get; set; }
        public string NoOfSeats { get; set; }
        public string TypeId { get; set; }
        
        public string BusType { get; set; } //view model
    }
}
