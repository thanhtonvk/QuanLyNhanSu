using ArrayToExcel;
using DocumentFormat.OpenXml.Bibliography;
using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSu.UI.Control
{
    public partial class BacLuong : UserControl
    {
        private BacLuongDAO _dao = new BacLuongDAO();
        private List<Model.BacLuong> list = new List<Model.BacLuong>();
        public BacLuong()
        {
            InitializeComponent();
        }

        private void BacLuong_Load(object sender, EventArgs e)
        {
            listPage.Columns[0].Width = (int)(listPage.Width * 0.25);
            listPage.Columns[1].Width = (int)(listPage.Width * 0.25);
            listPage.Columns[2].Width = (int)(listPage.Width * 0.25);
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bậc lương");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên bậc lương");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxHeSoBacLuong.Text))
            {
                MessageBox.Show("Không được bỏ trống hệ số lương");
                return;
            }
            bool isNumeric = double.TryParse(textBoxHeSoBacLuong.Text, out double result);

            if (!isNumeric)
            {
                MessageBox.Show("Hệ số lương không được nhập chữ");
                return;
            }

            if (_dao.Insert(new Model.BacLuong()
            {
                MaBL = textBoxMa.Text,
                TenBL = textBoxTen.Text,
                HeSBL = (float)double.Parse(textBoxHeSoBacLuong.Text),
            }))
            {
                OnLoadListView();
                textBoxMa.Text = "";
                textBoxTen.Text = "";
                textBoxHeSoBacLuong.Text = "";
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bậc lương");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên bậc lương");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxHeSoBacLuong.Text))
            {
                MessageBox.Show("Không được bỏ trống hệ số lương");
                return;
            }
            bool isNumeric = double.TryParse(textBoxHeSoBacLuong.Text, out double result);

            if (!isNumeric)
            {
                MessageBox.Show("Hệ số lương không được nhập chữ");
                return;
            }
            if (_dao.Update(new Model.BacLuong()
            {
                MaBL = textBoxMa.Text,
                TenBL = textBoxTen.Text,
                HeSBL = (float)double.Parse(textBoxHeSoBacLuong.Text),
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bậc lương");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                if (_dao.Delete(textBoxMa.Text))
                {
                    OnLoadListView();
                    textBoxMa.Text = "";
                    textBoxTen.Text = "";
                    textBoxHeSoBacLuong.Text = "";
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
                textBoxHeSoBacLuong.Text = listPage.SelectedItems[0].SubItems[2].Text;
            }
        }
        //Load data vào list view
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            list = _dao.GetAll();
            foreach (var item in list)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaBL);
                viewItem.SubItems.Add(item.TenBL);
                viewItem.SubItems.Add(item.HeSBL.ToString());
            }
        }

        private void check(object sender, KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //start excel
            var excel = _dao.GetAll().ToExcel();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("Excel File|*.xlsx");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, excel);
            }
        }
    }
}
