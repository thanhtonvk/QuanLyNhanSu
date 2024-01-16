using QuanLyNhanSu.DAO;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyNhanSu
{
    public partial class DangNhap : Form
    {
        private UserDAO _userDao = new UserDAO();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Không được bỏ trống username");
            }

            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống password");
            }

            if (!String.IsNullOrWhiteSpace(txtUsername.Text) && !String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (_userDao.UserExists(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();
                    Start start = new Start();
                    start.Show();


                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }

        }
    }
}