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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyNhanSu.UI.Control
{
    public partial class ChucVuNhanVien : UserControl
    {
        private ChucVuDAO _chucVuDAO = new ChucVuDAO();
        private List<Model.ChucVu> chucVuList = new List<Model.ChucVu>();

        private ChucVuNhanVienDAO _chucVuNhanVienDAO = new ChucVuNhanVienDAO();
        private List<Model.ChucVuNhanVien> chucVuNhanList = new List<Model.ChucVuNhanVien>();


        public ChucVuNhanVien()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
          
        }

        private void ChucVuNhanVien_Load(object sender, EventArgs e)
        {
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();

            comboBoxMaChucVu.Items.Clear();
            chucVuList = _chucVuDAO.Get();
            comboBoxMaChucVu.DataSource = chucVuList;
            comboBoxMaChucVu.ValueMember = "MaCV";
            comboBoxMaChucVu.DisplayMember = "MaCV";

            comboBoxMaChucVu.Text = "";

        }
        //Load data vào list view
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            chucVuNhanList = _chucVuNhanVienDAO.GetAll();
            foreach (var item in chucVuNhanList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.MaCV);
                viewItem.SubItems.Add(item.TenCV);
                viewItem.SubItems.Add(item.NgayBD.ToString());
                viewItem.SubItems.Add(item.NgayKT.ToString());
            }
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

        private void comboBoxMaChucVu_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMaNhanVien.Text = listPage.SelectedItems[0].SubItems[0].Text;
                comboBoxMaChucVu.Text = listPage.SelectedItems[0].SubItems[2].Text;
                dateTimePickerNgayBd.Text = listPage.SelectedItems[0].SubItems[4].Text;
                dateTimePickerNgayKt.Text = listPage.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(comboBoxMaChucVu.Text))
            {
                MessageBox.Show("Không được bỏ trống mã chúc vụ");
                return;
            }


            if (_chucVuNhanVienDAO.Insert(new Model.ChucVuNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                NgayBD = DateTime.Parse(dateTimePickerNgayBd.Value.ToShortDateString()),
                NgayKT = DateTime.Parse(dateTimePickerNgayKt.Value.ToShortDateString()),
                MaCV = comboBoxMaChucVu.Text,
            }))
            {
                OnLoadListView();
                textBoxMaNhanVien.Text = "";
                comboBoxMaChucVu.Text = "";
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

            if (String.IsNullOrWhiteSpace(comboBoxMaChucVu.Text))
            {
                MessageBox.Show("Không được bỏ trống mã chúc vụ");
                return;
            }


            if (_chucVuNhanVienDAO.Update(new Model.ChucVuNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                NgayBD = DateTime.Parse(dateTimePickerNgayBd.Value.ToShortDateString()),
                NgayKT = DateTime.Parse(dateTimePickerNgayKt.Value.ToShortDateString()),
                MaCV = comboBoxMaChucVu.Text,
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
                if (_chucVuNhanVienDAO.Delete(textBoxMaNhanVien.Text, comboBoxMaChucVu.Text))
                {
                    OnLoadListView();
                    textBoxMaNhanVien.Text = "";
                    comboBoxMaChucVu.Text = "";
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chucVuNhanList.Clear();
            listPage.Items.Clear();
            chucVuNhanList = _chucVuNhanVienDAO.Get(textBoxTimKiem.Text);
            foreach (var item in chucVuNhanList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.MaCV);
                viewItem.SubItems.Add(item.TenCV);
                viewItem.SubItems.Add(item.NgayBD.ToString());
                viewItem.SubItems.Add(item.NgayKT.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnLoadListView();
        }
    }
}
