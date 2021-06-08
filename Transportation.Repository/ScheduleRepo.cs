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
    public class ScheduleRepo
    {
        public static string GetId() //Used to generate an Id
        {
            string sql = "select TOP 1 * from [Schedule] order by schedule_id DESC;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                string appId = data.Rows[0].Field<string>(0);
                int id = Convert.ToInt32(appId.Split('-')[1]);
                ++id;
                return $"sc-{id}";
            }
            return "sc-1";
        }
        
        public static bool Insert(Schedule schedule)
        {
            string sql = $"INSERT INTO [Schedule] VALUES('{schedule.ScheduleId}', '{schedule.DeptTime}', '{schedule.ArrivalTime}', '{schedule.RouteId}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1; 
        }
        
        public static bool Update(Schedule schedule)
        {
            var sql = $"UPDATE [Schedule] SET schedule_id = '{schedule.ScheduleId}', dept_time = '{schedule.DeptTime}', arrival_time = '{schedule.ArrivalTime}' where schedule_id = '{schedule.ScheduleId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static string GetScheduleId(string routeId)
        {
            string sql = $"select schedule_id from [schedule] where route_id = '{routeId}';";
            var dt = DataAccess.GetDataTable(sql);

            string id = dt.Rows[0][0].ToString();
            return id;
        }
    }
}