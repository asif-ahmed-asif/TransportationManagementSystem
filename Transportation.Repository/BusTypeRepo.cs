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

        public static string[] GetBusTypeByRoute(string departure,string destination)
        {
            var sqlQuery = $@"select bus_type
                                from  bus_type
                                join bus
                                on bus.type_id=bus_type.type_id
                                join route
                                on route.bus_no=bus.bus_no
                                where dept_location='{departure}'
                                and destination='{destination}'";
            var row = DataAccess.GetDataTable(sqlQuery);

            string[] busTypes = new string[row.Rows.Count];
            byte index = 0;
            while (index < row.Rows.Count)
            {
                busTypes[index] = row.Rows[index][index].ToString();
                index++;
            }

            return busTypes;
        }
    }
}