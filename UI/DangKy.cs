using System;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu
{
    public partial class DangKy : Form
    {
        private UserDAO _userDao = new UserDAO();

        public DangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Không được bỏ trống tên");
            }

            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Không được bỏ trống username");
            }

            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống password");
            }

            if (!String.IsNullOrWhiteSpace(txtName.Text) && !String.IsNullOrWhiteSpace(txtUsername.Text) &&
                !String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (_userDao.Insert(new User()
                    {
                        HoTen = txtName.Text,
                        Password = txtPassword.Text,
                        Quyen = "",
                        UserName = txtUsername.Text
                    }))
                {
                    MessageBox.Show("Đăng ký tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản không thành công");
                }
            }
        }
    }
}