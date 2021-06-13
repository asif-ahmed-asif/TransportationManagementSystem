using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class BusRepo
    {

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
        
        public static int SearchBusId(string key)
        {
            if (key == null)
            {
                return 0;
            }
            var sql = "select * from [bus] where bus_no = '" + key + "';";
            var dt = DataAccess.GetDataTable(sql);
            return dt.Rows.Count;
        }
        
        public static bool Update(Bus bus, string key)
        {
            var sql = $"UPDATE [bus] SET bus_no = '{bus.BusNo}', no_of_seats = '{bus.NoOfSeats}', type_id = '{bus.TypeId}' where bus_no = '"+ key + "';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static List<Bus> GetAll()
        {
            string sql = "SELECT * FROM bus WHERE bus.bus_no NOT IN (SELECT route.bus_no FROM route)";
            DataTable data = DataAccess.GetDataTable(sql);

            int i = 0;
            List<Bus> busData = new List<Bus>();
            while (i < data.Rows.Count)
            {
                Bus bus = ConvertToEntity(data.Rows[i]);
                busData.Add(bus);
                i++;
            }
            return busData;
        }

        public static Bus ConvertToEntity(DataRow data)
        {
            if (data == null)
            {
                return null;
            }
            else
            {
                Bus bus = new Bus
                {
                    BusNo = data["bus_no"].ToString(),
                    NoOfSeats = data["no_of_seats"].ToString(),
                    TypeId = data["type_id"].ToString()
                };

                return bus;
            }
        }
        
        public static Bus ConvertToEntityBusAndBusType(DataRow data)
        {
            if (data == null)
            {
                return null;
            }
            else
            {
                Bus bus = new Bus
                {
                    BusNo = data["bus_no"].ToString(),
                    NoOfSeats = data["no_of_seats"].ToString(),
                    TypeId = data["type_id"].ToString(),
                    BusType = data["bus_type"].ToString() //assigning to a view model property
                };

                return bus;
            }
        }
        
        public static List<Bus> ShowAll()
        {
            string sqlQuery = @"select * from bus, bus_type
                                where bus.type_id = bus_type.type_id";

            DataTable data = DataAccess.GetDataTable(sqlQuery);

            List<Bus> buses = new List<Bus>();
            int index = 0;
            while (index < data.Rows.Count)
            {
                Bus bus = ConvertToEntityBusAndBusType(data.Rows[index]);
                buses.Add(bus);
                index++;
            }

            return buses;
        }
        
        public static List<Bus> LiveSearchBus(string key)
        {
            string sqlQuery = @"select * from bus, bus_type
                                where bus_no like '%" + key + "%'" +
                                " and bus.type_id = bus_type.type_id";
            
            DataTable data = DataAccess.GetDataTable(sqlQuery);

            List<Bus> buses = new List<Bus>();
            int index = 0;
            
            while (index < data.Rows.Count)
            {
                Bus route = ConvertToEntityBusAndBusType(data.Rows[index]);
                buses.Add(route);
                index++;
            }

            return buses;
        }

        public static string[] GetUnassignedBuses()
        {
            //returns the buses that have been assigned only one active route 
            string sql = $"select bus_no from route where route.status='Active' group by bus_no having count(bus_no)= 1";

            DataTable data = DataAccess.GetDataTable(sql);

            string[] buses = new string[data.Rows.Count];
            int index = 0;

            while (index < data.Rows.Count)
            {
                buses[index] = data.Rows[index][0].ToString();

                index++;
            }

            return buses;
        }
    }
}