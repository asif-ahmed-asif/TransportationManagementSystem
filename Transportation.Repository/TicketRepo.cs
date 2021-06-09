
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data;
using Microsoft.Reporting.WebForms;
using System.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class TicketRepo
    {
        public static DataTable  printTicket()
        {
            var sql = "select TOP 1 * from print_ticket order by id DESC;";
            var dt = DataAccess.GetDataTable(sql);

           // ReportDataSource dataSource = new ReportDataSource("DatasetTicket", dt);
            

            return dt;

        }

        public static DataTable getSchedule(string from, string to, string busType)
        {
            string[] id = getRouteAndBusId(from,to,busType);//id[0]=routeid, id[1]=busNO
            string sql = $"select dept_time, arrival_time,bus_no from schedule join route on schedule.route_id = route.route_id where route.route_id='{id[0]}'";
            var scheduleTable = DataAccess.GetDataTable(sql);
            return scheduleTable;

        }


        public static string[] getRouteAndBusId(string from,string to,string busType) 
        {
            busType = BusTypeRepo.GetBusTypeForBus(busType);
            string sql = $"select route_id,route.bus_no from route join bus on route.bus_no = bus.bus_no where dept_location = '{from}' and destination = '{to}' and type_id = '{busType}'";
            var row = DataAccess.GetDataTable(sql);
            string[] id = new string[2];
            id[0]=row.Rows[0][0].ToString();//route id
            id[1]= row.Rows[0][1].ToString();// bus number
            return id;

        }

        public static void Insert(Ticket ticket)
        {

            string sql = $"insert into ticket values('{ticket.CustomerName}','{ticket.CustomerPhone}','{ticket.JourneyDate}','{ticket.SeatNo}','{ticket.ScheduleId}')";
            DataAccess.ExecuteDmlQuery(sql);
        }
    }
}
