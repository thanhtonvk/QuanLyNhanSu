using QuanLyNhanSu.DAO;
using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyNhanSu.UI.Control
{
    public partial class PhongBan : UserControl
    {
        private PhongBanDAO _phongBanDAO = new PhongBanDAO();
        private List<Model.PhongBan> phongBanList = new List<Model.PhongBan>();
        public PhongBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaPhongBan.Text))
            {
                MessageBox.Show("Không được bỏ trống mã phòng ban");
            }

            if (String.IsNullOrWhiteSpace(textBoxTenPhongBan.Text))
            {
                MessageBox.Show("Không được bỏ trống tên phòng ban");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMaPhongBan.Text) && !String.IsNullOrWhiteSpace(textBoxTenPhongBan.Text))
            {
                if (_phongBanDAO.Insert(new Model.PhongBan()
                {
                    MaPB = textBoxMaPhongBan.Text,
                    TenPB = textBoxTenPhongBan.Text,
                }))
                {
                    OnLoadListView();
                    textBoxMaPhongBan.Text = "";
                    textBoxTenPhongBan.Text = "";
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMaPhongBan.Text = listPage.SelectedItems[0].SubItems[0].Text;
                textBoxTenPhongBan.Text = listPage.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            listPage.Columns[0].Width = (int)(listPage.Width * 0.25);
            listPage.Columns[1].Width = (int)(listPage.Width * 0.25);
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();
        }

        //Load data vào list view
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            phongBanList = _phongBanDAO.GetAll();
            foreach (var item in phongBanList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaPB);
                viewItem.SubItems.Add(item.TenPB);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaPhongBan.Text))
            {
                MessageBox.Show("Không được bỏ trống mã phòng ban");
            }

            if (String.IsNullOrWhiteSpace(textBoxTenPhongBan.Text))
            {
                MessageBox.Show("Không được bỏ trống tên phòng ban");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMaPhongBan.Text) && !String.IsNullOrWhiteSpace(textBoxTenPhongBan.Text))
            {
                if (_phongBanDAO.Update(new Model.PhongBan()
                {
                    MaPB = textBoxMaPhongBan.Text,
                    TenPB = textBoxTenPhongBan.Text,
                }))
                {
                    OnLoadListView();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaPhongBan.Text))
            {
                MessageBox.Show("Không được bỏ trống mã phòng ban");
            }


            if (!String.IsNullOrWhiteSpace(textBoxMaPhongBan.Text) )
            {
                if (_phongBanDAO.Delete(textBoxMaPhongBan.Text))
                {
                    OnLoadListView();
                    textBoxMaPhongBan.Text = "";
                    textBoxTenPhongBan.Text = "";
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void textBoxMaPhongBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTenPhongBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelPhongBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
