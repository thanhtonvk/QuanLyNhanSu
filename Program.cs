using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            UserDAO userDao = new UserDAO();
            userDao.Insert(new User()
            {
                HoTen = "Do thanh ton",
                Password = "12345",
                Quyen = "Admin",
                UserName = "hello"
            });
            List<User> list = userDao.Gets("");
            foreach (User user in list)
            {
                Console.WriteLine(user.UserName);
            }
            
        }
    }
}
