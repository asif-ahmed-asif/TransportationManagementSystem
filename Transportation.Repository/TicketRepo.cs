
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data;
using Microsoft.Reporting.WebForms;
using System.Data;

namespace Transportation.Repository
{
    public class TicketRepo
    {
        public static DataTable  printTicket()
        {
            var sql = "select TOP 1 * from print_ticket order by ticket_id DESC;";
            var dt = DataAccess.GetDataTable(sql);

           // ReportDataSource dataSource = new ReportDataSource("DatasetTicket", dt);
            

            return dt;

        }

        public static string getRouteId(string from,string to,string busType) 
        {
            busType = BusTypeRepo.GetBusTypeForBus(busType);
            string sql = $"select route_id from route join bus on route.bus_no = bus.bus_no where dept_location = '{from}' and destination = '{to}' and type_id = '{busType}'";
            var row = DataAccess.GetDataTable(sql);
            string routeId = row.Rows[0][0].ToString();
            return routeId;

        }
    }
}
