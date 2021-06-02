
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
    }
}
