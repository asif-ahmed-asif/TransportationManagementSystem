using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Entity;
using Transportation.Data;

namespace Transportation.Repository
{
    public class LoginRepo
    {
        public static bool Save(Login l)
        {
            var sql = $"INSERT INTO [login] VALUES('{l.Password}', '{l.UserId}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static bool Update(Login l)
        {
            var sql = $"UPDATE [login] SET password = '{l.Password}' where user_id = '{l.UserId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static string[] VerifyLogin(string uid, string pass)
        {
            string sql = $"select [user].user_type, [user].status FROM [user] INNER JOIN login ON [user].user_id = login.user_id where login.user_id = '{uid}' and login.password = '{pass}'";
            var row = DataAccess.GetDataTable(sql);
            string[] loginDetails = new string[2];
            loginDetails[0] = row.Rows[0][0].ToString(); //user type
            loginDetails[1] = row.Rows[0][1].ToString();// status
            return loginDetails;

        }
    }

    
}
