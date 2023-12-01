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

namespace QuanLyNhanSu.UI.Control
{
    public partial class TrinhDo : UserControl
    {
        private TrinhDoDAO _trinhDoDAO = new TrinhDoDAO();
        private List<Model.TrinhDo> list = new List<Model.TrinhDo>();
        public TrinhDo()
        {
            InitializeComponent();
        }

        private void TrinhDo_Load(object sender, EventArgs e)
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
            list = _trinhDoDAO.GetAll();
            foreach (var item in list)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaTD);
                viewItem.SubItems.Add(item.TenTD);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã trình độ");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên trình độ");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_trinhDoDAO.Insert(new Model.TrinhDo()
                {
                    MaTD = textBoxMa.Text,
                    TenTD = textBoxTen.Text,
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

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã trình độ");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên trình độ");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_trinhDoDAO.Update(new Model.TrinhDo()
                {
                    MaTD = textBoxMa.Text,
                    TenTD = textBoxTen.Text,
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
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã trình độ");
            }


            if (!String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                if (_trinhDoDAO.Delete(textBoxMa.Text))
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

        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMa.Text = listPage.SelectedItems[0].SubItems[0].Text;
                textBoxTen.Text = listPage.SelectedItems[0].SubItems[1].Text;
            }
        }
    }
}
