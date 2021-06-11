using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class SalesRepo
    {
        public static List<Sales> UserSalesByDate(string date)
        {
            string sqlQuery = @"select sales.*, [user].name
                                from sales, [user]
                                where sales.user_id = [user].user_id
                                and date = '"+date+"';";
            
            DataTable data = DataAccess.GetDataTable(sqlQuery);

            List<Sales> userSales = new List<Sales>();
            int index = 0;
            
            while (index < data.Rows.Count)
            {
                Sales sales = ConvertToEntityForUserSales(data.Rows[index]);
                userSales.Add(sales);
                index++;
            }

            return userSales;
        }

        public static Sales ConvertToEntityForUserSales(DataRow dataRow)
        {
            if (dataRow == null)
            {
                return null;
            }
            
            var userSales = new Sales();
            userSales.Name = dataRow["name"].ToString();
            userSales.UserId = dataRow["user_id"].ToString();
            userSales.TotalAmount = Double.Parse(dataRow["total_amount"].ToString());

            var dateTime = DateTime.Parse(dataRow["date"].ToString()); //parsing date so that the time portion is trimmed

            userSales.Date = dateTime.ToString("yyyy/MM/dd"); //Now assigning the formatted date

            return userSales;
        }

        public static int CurrentSalesAmount(string uid)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            string sql = $"select total_amount from [sales] where user_id = '{uid}' and date = '{date}';";
            var dt = DataAccess.GetDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                string amount = dt.Rows[0][0].ToString();
                return Int32.Parse(amount);
            }
            return 0;
        }

        public static bool Update(string uid, int amount)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            var sql = $"UPDATE [sales] SET total_amount = '{amount}' where user_id = '{uid}' and date = '{date}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static bool Insert(string uid, int amount)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            var sql = $"INSERT INTO [sales] VALUES('{uid}', '{amount}', '{date}');";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        
        public static List<Sales> LiveSearchUser(string key, string date)
        {
            string sqlQuery = $@"select sales.*, [user].name
                                from sales, [user]
                                where sales.user_id = [user].user_id
                                and date = '{date}'
                                and [user].user_id like '%" + key + "%'" +
                              " or [user].name like '%" + key + "%'" +
                              " and sales.user_id = [user].user_id" +
                              " and date = '" + date + "'";
            
            DataTable data = DataAccess.GetDataTable(sqlQuery);

            List<Sales> userSales = new List<Sales>();
            int index = 0;
            
            while (index < data.Rows.Count)
            {
                Sales sales = ConvertToEntityForUserSales(data.Rows[index]);
                userSales.Add(sales);
                index++;
            }

            return userSales;
        }
    }
}