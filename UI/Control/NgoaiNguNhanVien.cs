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
    public partial class NgoaiNguNhanVien : UserControl
    {
        private NgoaiNguDAO _ngoaiNguDAO = new NgoaiNguDAO();
        private List<Model.NgoaiNgu> ngoaiNguList = new List<Model.NgoaiNgu>();

        private NgoaiNguNhanVienDAO _ngoaiNguNhanVienDAO = new NgoaiNguNhanVienDAO();
        private List<Model.NgoaiNguNhanVien> ngoaiNguNhanVienList = new List<Model.NgoaiNguNhanVien>();
        public NgoaiNguNhanVien()
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

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
        }

        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMaNhanVien.Text = listPage.SelectedItems[0].SubItems[0].Text;
                comboBoxMa.Text = listPage.SelectedItems[0].SubItems[1].Text;
                dateTimePickerNgayCap.Text = listPage.SelectedItems[0].SubItems[3].Text;
            }

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        //Load data vào list view
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            ngoaiNguNhanVienList = _ngoaiNguNhanVienDAO.GetAll();
            foreach (var item in ngoaiNguNhanVienList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.MaNN);
                viewItem.SubItems.Add(item.TenNN);
                viewItem.SubItems.Add(item.NgayCap.ToString());
            }
        }

        private void NgoaiNguNhanVien_Load(object sender, EventArgs e)
        {
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();

            comboBoxMa.Items.Clear();
            ngoaiNguList = _ngoaiNguDAO.GetAll();
            comboBoxMa.DataSource = ngoaiNguList;
            comboBoxMa.ValueMember = "MaNN";
            comboBoxMa.DisplayMember = "MaNN";

            comboBoxMa.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(comboBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã ngoại ngữ");
                return;
            }

            if (_ngoaiNguNhanVienDAO.Insert(new Model.NgoaiNguNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                MaNN = comboBoxMa.Text,
                NgayCap = DateTime.Parse(dateTimePickerNgayCap.Value.ToShortDateString()),
            }))
            {
                OnLoadListView();
                textBoxMaNhanVien.Text = "";
                comboBoxMa.Text = "";
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(comboBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã ngoại ngữ");
                return;
            }

            if (_ngoaiNguNhanVienDAO.Update(new Model.NgoaiNguNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                MaNN = comboBoxMa.Text,
                NgayCap = DateTime.Parse(dateTimePickerNgayCap.Value.ToShortDateString()),
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
            }


            if (!String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                if (_ngoaiNguNhanVienDAO.Delete(textBoxMaNhanVien.Text, comboBoxMa.Text))
                {
                    OnLoadListView();
                    textBoxMaNhanVien.Text = "";
                    comboBoxMa.Text = "";
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ngoaiNguNhanVienList.Clear();
            listPage.Items.Clear();
            ngoaiNguNhanVienList = _ngoaiNguNhanVienDAO.Get(textBoxTimKiem.Text);
            foreach (var item in ngoaiNguNhanVienList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.MaNN);
                viewItem.SubItems.Add(item.TenNN);
                viewItem.SubItems.Add(item.NgayCap.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            OnLoadListView();
        }
    }
}
