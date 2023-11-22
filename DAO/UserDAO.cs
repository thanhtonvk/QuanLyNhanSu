using System.Collections.Generic;
using System.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.DAO
{
    public class UserDAO
    {
        private DataHandle _handle;

        public UserDAO()
        {
            _handle = new DataHandle();
        }

        public List<User> Gets(string keyword)
        {
            List<User> users = new List<User>();
            string query = $"select * from [User] where HoTen like N'%{keyword}%' or UserName like N'%{keyword}%'";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(new User()
                {
                    HoTen = row["HoTen"].ToString(),
                    Password = row["Password"].ToString(),
                    Quyen = row["Quyen"].ToString(),
                    UserName = row["UserName"].ToString()
                });
            }

            return users;
        }

        public bool Insert(User user)
        {
            string query =
                $"insert into [User](UserName, HoTen, Password, Quyen) values ('{user.UserName}',N'{user.HoTen}','{user.Password}','{user.Quyen}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(User user,string username)
        {
            string query =
                $"update [User] set HoTen = N'{user.HoTen}',Password='{user.Password}',Quyen='{user.Quyen}' where UserName = '{username}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string username)
        {
            string query = $"delete [User] where UserName = '{username}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}