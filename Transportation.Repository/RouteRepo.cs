using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class RouteRepo
    {
        public static List<Route> GetAll()
        {
            var routeList = new List<Route>();
            string sql = "SELECT * FROM route";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Route routes = ConvertToEntity(dt.Rows[row]);
                routeList.Add(routes);
                row++;
            }
            return routeList;
        }

        public static string[] GetAllDeptLocation()
        {
            string sql = $"select dept_location from route group by dept_location";
            var dt = DataAccess.GetDataTable(sql);
            string[] list = new string[dt.Rows.Count];
            int row = 0;
            while (row < dt.Rows.Count)
            {
                list[row] = dt.Rows[row][0].ToString();
                row++;
            }

            return list;
        }

        private static Route ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var r = new Route();
            r.RouteId = row["route_id"].ToString();
            r.DeptLocation = row["dept_location"].ToString();
            r.Destination = row["destination"].ToString();
            r.BusNo = row["bus_no"].ToString();
            r.Fare = row["fare"].ToString();
            r.Status = row["status"].ToString();
            return r;
        }
        
        private static Route ConvertToEntityForRouteSchedule(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var r = new Route();
            r.RouteId = row["route_id"].ToString();
            r.DeptLocation = row["dept_location"].ToString();
            r.Destination = row["destination"].ToString();
            r.BusNo = row["bus_no"].ToString();
            r.ScheduleId = row["schedule_id"].ToString();
            r.ArrivalTime = row["arrival_time"].ToString();
            r.DeptTime = row["dept_time"].ToString();
            r.Status = row["status"].ToString();
            r.Fare = row["fare"].ToString();
            return r;
        }
        
        public static string GetId() //Used to generate an Id
        {
            string sql = "select TOP 1 * from [Route] order by route_id DESC;";
            var dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["route_id"].ToString();
               
                int intId=int.Parse(id) ;
                intId++;
                return intId.ToString();
            }

            return "01";
        }
        
        public static bool SearchRouteId(string key)
        {
            var sql = "select * from [Route] where route_id = '" + key + "';";
            var dt = DataAccess.GetDataTable(sql);
            return dt.Rows.Count == 1;
        }
        
        public static bool Insert(Route route)
        {
            var sql = $"INSERT INTO [Route] VALUES('{route.RouteId}', '{route.DeptLocation}', '{route.Destination}', '{route.BusNo}', '{route.Status}', '{route.Fare}')"; //'{route.ScheduleId}',
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1; 
        }
        
        public static bool Update(Route route)
        {
            var sql = $"UPDATE [Route] SET route_id = '{route.RouteId}', dept_location = '{route.DeptLocation}', destination = '{route.Destination}', bus_no = '{route.BusNo}' , status = '{route.Status}', fare = '{route.Fare}' where route_id = '{route.RouteId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static List<Route> ShowAll()
        {
            string sqlQuery = "select route.*, schedule.* " +
                              "from route, schedule " +
                              "where route.route_id = schedule.route_id";

            DataTable data = DataAccess.GetDataTable(sqlQuery);

            List<Route> routes = new List<Route>();
            int index = 0;
            while (index < data.Rows.Count)
            {
                Route route = ConvertToEntityForRouteSchedule(data.Rows[index]);
                routes.Add(route);
                index++;
            }

            return routes;
        }

        public static List<Route> LiveSearchRoutes(string key)
        {
            string sqlQuery = @"select route.*, schedule.* from route, schedule
                                where route.route_id = schedule.route_id
                                and dept_location like '%" + key + "%'" +
                              " or destination like '%" + key + "%'" +
                              " and route.route_id = schedule.route_id";
            
            DataTable data = DataAccess.GetDataTable(sqlQuery);

            List<Route> routes = new List<Route>();
            int index = 0;
            
            while (index < data.Rows.Count)
            {
                Route route = ConvertToEntityForRouteSchedule(data.Rows[index]);
                routes.Add(route);
                index++;
            }

            return routes;
        }

        public static string BusTypeForRoute(string key)
        {
            string sqlQuery = @"select bus_type from bus_type, bus
                                where bus.type_id = bus_type.type_id
                                and bus_no = '" + key + "';";
            
            DataTable data = DataAccess.GetDataTable(sqlQuery);
            if (data.Rows.Count > 0)
            {
                string rowData = data.Rows[0][0].ToString();
                return rowData;
            }
            //string rowData = data.Rows[0][0].ToString();
            return null;
        }
    }
}
