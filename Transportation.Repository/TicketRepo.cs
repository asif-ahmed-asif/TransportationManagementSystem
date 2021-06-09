
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

        public static DataTable getSchedule(string from, string to, string busType,string date)
        {
            busType = BusTypeRepo.GetBusTypeForBus(busType);
           // string[] id = getRouteAndBusId(from,to,busType);//id[0]=routeid, id[1]=busNO
            string sql = $"select dept_time,arrival_time,available_seat_count from schedule join route on route.route_id = schedule.route_id join booking on schedule.schedule_id = booking.schedule_id join bus on route.bus_no = bus.bus_no where dept_location = '{from}' and destination = '{to}' and journey_date = '{date}' and type_id = '{busType}'";
            var row = DataAccess.GetDataTable(sql);

            if (row.Rows.Count <=0)
            {
                Console.WriteLine("12");
                sql = $"select dept_time,arrival_time, '37' as available_seat_count from schedule join route on route.route_id=schedule.route_id join bus on route.bus_no=bus.bus_no where dept_location='{from}' and destination='{to}' and type_id='{busType}'";
                row = DataAccess.GetDataTable(sql);
            }
                return row;

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

        private static void getRouteId(string from, string to, string busType)
        {
            busType = BusTypeRepo.GetBusTypeForBus(busType);
            string sql = $"select route_id,route.bus_no from route join bus on route.bus_no = bus.bus_no where dept_location = '{from}' and destination = '{to}' and type_id = '{busType}'";
            // var row
           // return "1";
        }

        public static void Insert(Ticket ticket)
        {

            string sql = $"insert into ticket values('{ticket.CustomerName}','{ticket.CustomerPhone}','{ticket.JourneyDate}','{ticket.SeatNo}','{ticket.ScheduleId}')";
            DataAccess.ExecuteDmlQuery(sql);
        }
    }
}
