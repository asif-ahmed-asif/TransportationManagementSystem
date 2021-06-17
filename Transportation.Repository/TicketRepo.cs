
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
using System.Reflection;

namespace Transportation.Repository
{
    public class TicketRepo
    {
        public static DataTable  printTicket(string phone)
        {
            var sql = $"select TOP 1 * from print_ticket where customer_phone = '{phone}' order by id DESC;";
            var dt = DataAccess.GetDataTable(sql);
            Ticket ticket = ConvertToEntity(dt.Rows[0]);
            var tList = new List<Ticket>();
            tList.Add(ticket);

            DataTable dataTable = ToDataTable(tList);

            return dt;
        }
        private static Ticket ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var t = new Ticket();
            t.CustomerName = row["customer_name"].ToString();
            t.CustomerPhone = row["customer_phone"].ToString();
            var dateTime = DateTime.Parse(row["journey_date"].ToString());
            t.JourneyDate = dateTime.ToString("yyyy/MM/dd");
            t.SeatNo = row["seat_no"].ToString();
            t.DeptLocation = row["dept_location"].ToString();
            t.Destination = row["destination"].ToString();
            t.DeptTime = row["dept_time"].ToString();

            return t;
        }

        private static DataTable ToDataTable<T>(List<T> items)

        {

            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)

            {

                //Setting column names as Property names

                dataTable.Columns.Add(prop.Name);

            }

            foreach (T item in items)

            {

                var values = new object[Props.Length];

                for (int i = 0; i < Props.Length; i++)

                {

                    //inserting property values to datatable rows

                    values[i] = Props[i].GetValue(item, null);

                }

                dataTable.Rows.Add(values);

            }

            //put a breakpoint here and check datatable

            return dataTable;

        }

        public static DataTable getSchedule(string from, string to, string busType,string date)
        {
            busType = BusTypeRepo.GetBusTypeForBus(busType);
           // string[] id = getRouteAndBusId(from,to,busType);//id[0]=routeid, id[1]=busNO
            string sql = $"select schedule.schedule_id, dept_time,arrival_time,available_seat_count from schedule join route on route.route_id = schedule.route_id join booking on schedule.schedule_id = booking.schedule_id join bus on route.bus_no = bus.bus_no where dept_location = '{from}' and destination = '{to}' and journey_date = '{date}' and type_id = '{busType}'";
            var row = DataAccess.GetDataTable(sql);

            if (row.Rows.Count <=0)
            {
                //Console.WriteLine("12");
                sql = $"select schedule.schedule_id, dept_time,arrival_time, '37' as available_seat_count from schedule join route on route.route_id=schedule.route_id join bus on route.bus_no=bus.bus_no where dept_location='{from}' and destination='{to}' and type_id='{busType}'";
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

        private static string getRouteId(string scheduleId)
        {

            string sql = $"select route_id from schedule where swchedule_id='{scheduleId}'";
            var row = DataAccess.GetDataTable(sql);
            string id=row.Rows[0][0].ToString();//route id
            return id;
        }

        public static string GetFare(string scheduleId)
        {
            
            string sql = $@"select fare from route
                            join schedule
                            on route.route_id=schedule.route_id
                            where schedule_id='{scheduleId}'";
            var row = DataAccess.GetDataTable(sql);
            string fare = row.Rows[0][0].ToString();//route id
            return fare;
        }
        public static void Insert(Ticket ticket)
        {

            string sql = $"insert into ticket values('{ticket.CustomerName}','{ticket.CustomerPhone}','{ticket.JourneyDate}','{ticket.SeatNo}','{ticket.ScheduleId}','{ticket.TotalFare}')";
            DataAccess.ExecuteDmlQuery(sql);
        }
    }
}
