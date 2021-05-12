using System.Data;
using Transportation.Data;

namespace Transportation.Repository
{
    public class BusTypeRepo
    {
        public static string GetBusTypeForBus(string busType)
        {
            var sqlQuery = "select top 1 * from bus_type where bus_type = '" +busType+"';";
            var row = DataAccess.GetDataTable(sqlQuery);
            string data = row.Rows[0][0].ToString();
            return data;
        }
    }
}