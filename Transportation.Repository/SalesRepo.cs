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
    }
}