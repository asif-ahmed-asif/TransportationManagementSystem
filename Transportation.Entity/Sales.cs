using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Entity
{
    public class Sales
    {
        public string UserId { get; set; }
        public double TotalPrice { get; set; }

        public string UpdatedAt = "GETDATE()";
    }
}
