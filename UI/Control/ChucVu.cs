using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhanSu.UI.Control
{
    public partial class ChucVu : UserControl
    {
        private ChucVuDAO _dao = new ChucVuDAO();
        private List<Model.ChucVu> list = new List<Model.ChucVu>();
        public ChucVu()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
          
        }

        private void update_Click(object sender, EventArgs e)
        {
           
        }

        private void delete_Click(object sender, EventArgs e)
        {
           
        }

        private void ChucVu_Load(object sender, EventArgs e)
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
            list = _dao.Get();
            foreach (var item in list)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaCV);
                viewItem.SubItems.Add(item.TenCV);
            }
        }
        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMa.Text = listPage.SelectedItems[0].SubItems[0].Text;
                textBoxTen.Text = listPage.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void panelPhongBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã chức vụ");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên chức vụ");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_dao.Insert(new Model.ChucVu()
                {
                    MaCV = textBoxMa.Text,
                    TenCV = textBoxTen.Text,
                }))
                {
                    OnLoadListView();
                    textBoxMa.Text = "";
                    textBoxTen.Text = "";
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã chức vụ");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên chức vụ");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_dao.Update(new Model.ChucVu()
                {
                    MaCV = textBoxMa.Text,
                    TenCV = textBoxTen.Text,
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã chức vụ");
            }


            if (!String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                if (_dao.Delete(textBoxMa.Text))
                {
                    OnLoadListView();
                    textBoxMa.Text = "";
                    textBoxTen.Text = "";
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }
    }
}
