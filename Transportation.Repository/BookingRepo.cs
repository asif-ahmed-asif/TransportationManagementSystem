using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public static  class BookingRepo
    {
        public static bool Save(Booking b)
        {
            var sql = $"INSERT INTO [booking] VALUES('{b.JourneyDate}', '{b.Seats}', '{b.ScheduleId}', {b.AvailableSeatCount})";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static string GetBookedSeats(string scheduleId, string date)
        {
            string sql = $"select seats from [booking] where journey_date = '{date}' and schedule_id = '{scheduleId}';";
            var dt = DataAccess.GetDataTable(sql);

            string id = dt.Rows[0][0].ToString();
            return id;
        }
    }
}
