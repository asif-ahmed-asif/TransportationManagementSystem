using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Transportation.Data;
using Transportation.Entity;

namespace Transportation.Repository
{
    public class UserRepo
    {
        public static bool Save(User u)
        {
            var sql = $"INSERT INTO [user] VALUES('{u.UserId}', '{u.Name}', '{u.Email}', '{u.Phone}', '{u.Address}', '{u.UserType}', '{u.Salary}', '{u.Status}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static bool Update(User u)
        {
            var sql = $"UPDATE [user] SET name = '{u.Name}', email = '{u.Email}', phone = '{u.Phone}', address = '{u.Address}', user_type = '{u.UserType}', salary = '{u.Salary}', status = '{u.Status}' where user_id = '{u.UserId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
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

        public static bool SearchUserId(string key)
        {
            var sql = "select * from [user] where user_id = '" + key + "';";
            var dt = DataAccess.GetDataTable(sql);
            return dt.Rows.Count == 1;
        }

        public static List<User> ShowAll()
        {
            var userList = new List<User>();
            var sql = @"SELECT [user].user_id, [user].name, [user].email, [user].phone,
                        [user].address, [user].user_type, [user].salary, [user].status, login.password FROM [user]
                        INNER JOIN login 
                            ON [user].user_id = login.user_id;";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                User user = ConvertToEntity(dt.Rows[row]);
                userList.Add(user);
                row++;
            }
            return userList;
        }

        public static List<User> SearchUser(string key)
        {
            var userList = new List<User>();
            var sql = @"SELECT [user].user_id, [user].name, [user].email, [user].phone,
                        [user].address, [user].user_type, [user].salary, [user].status, login.password FROM [user]
                        INNER JOIN login 
                            ON [user].user_id = login.user_id WHERE [user].name like '" + key + "%';";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                User user = ConvertToEntity(dt.Rows[row]);
                userList.Add(user);
                row++;
            }
            return userList;
        }
        private static User ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var u = new User();
            u.UserId = row["user_id"].ToString();
            u.Name = row["name"].ToString();
            u.Email = row["email"].ToString();
            u.Phone = row["phone"].ToString();
            u.Address = row["address"].ToString();
            u.UserType = row["user_type"].ToString();
            u.Salary = row["salary"].ToString();
            u.Status = row["status"].ToString();
            u.Password = row["password"].ToString();

            return u;
        }
    }
}
