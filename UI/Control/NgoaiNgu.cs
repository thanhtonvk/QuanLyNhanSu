using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSu.UI.Control
{
    public partial class NgoaiNgu : UserControl
    {
        private NgoaiNguDAO _ngoaiNguDAO = new NgoaiNguDAO();
        private List<Model.NgoaiNgu> list = new List<Model.NgoaiNgu>();

        public NgoaiNgu()
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

        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMa.Text = listPage.SelectedItems[0].SubItems[0].Text;
                textBoxTen.Text = listPage.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void NgoaiNgu_Load(object sender, EventArgs e)
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
            list = _ngoaiNguDAO.GetAll();
            foreach (var item in list)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNN);
                viewItem.SubItems.Add(item.TenNN);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã ngoại ngữ");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên ngoại ngữ");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_ngoaiNguDAO.InsertNgoaiNgu(textBoxMa.Text, textBoxTen.Text))
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
                MessageBox.Show("Không được bỏ trống mã ngoại ngữ");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên ngoại ngữ");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_ngoaiNguDAO.UpdateNgoaiNgu(textBoxMa.Text, textBoxTen.Text))
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
                MessageBox.Show("Không được bỏ trống mã ngoại ngữ");
            }


            if (!String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                if (_ngoaiNguDAO.DeleteNgoaiNgu(textBoxMa.Text))
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
