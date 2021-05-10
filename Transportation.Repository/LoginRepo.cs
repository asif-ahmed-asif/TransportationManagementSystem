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

        public static int CheckUserForLogin(Login login)
        {
            var sqlQuery = $"Select * From [login] where password = '{login.Password}' and user_id = '{login.UserId}';";
            var row = DataAccess.GetDataTable(sqlQuery);
            
            return row.Rows.Count;
        }
    }

    
}
