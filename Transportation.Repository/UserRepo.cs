using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class UserRepo
    {
        public static int InsertUsser(User user)
        {
            //float floatSalary = float.Parse(user.Salary);
            string sql = "insert into [user] values('"+GetId()+"','"+user.Name + "','" +user.Email + "','" +user.Phone + @"
                          ','" +user.Address + "','" +user.UserType + "'," +user.Salary+ ",'" +user.Status + "');";
          return DataAccess.ExecuteDmlQuery(sql);
        }

        public static string GetId()
        {
            string sql = "select TOP 1 * from [user] order by user_id DESC;";
            
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
    }
}
