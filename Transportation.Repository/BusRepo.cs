using System;
using System.Windows.Forms;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class BusRepo
    {
        public static string GetId()
        {
            string sql = "select TOP 1 * from [bus] order by bus_no DESC;";
            
            var dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["user_id"].ToString();
               
                int intId=int.Parse(id) ;
                intId++;
                return intId.ToString();
            }

            return "01";

      
        }

        public static int CheckBusNumber(string busNumber)
        {
            var sqlQuery = "select * from bus where bus_no = '" + busNumber + "'";
            var row = DataAccess.GetDataTable(sqlQuery);
            return row.Rows.Count;
        }
        
        public static bool Insert(Bus bus)
        {
            var sql = $"INSERT INTO [bus] VALUES('{bus.BusNo}', '{bus.NoOfSeats}', '{bus.TypeId}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1; 
        }
    }
}