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
    public partial class BaoHienNhanVien : UserControl
    {
        private BaoHiemDAO _baoHiemDAO = new BaoHiemDAO();
        private List<Model.BaoHiem> baoHiemList = new List<Model.BaoHiem>();

        private BaoHiemNhanVienDAO _baoHiemNhanVienDAO = new BaoHiemNhanVienDAO();
        private List<Model.BaoHiemNhanVien> baoHiemVienNhanList = new List<Model.BaoHiemNhanVien>();
        public BaoHienNhanVien()
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
            baoHiemVienNhanList.Clear();
            listPage.Items.Clear();
            baoHiemVienNhanList = _baoHiemNhanVienDAO.Get(textBoxTimKiem.Text);
            foreach (var item in baoHiemVienNhanList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.MaBH);
                viewItem.SubItems.Add(item.TenBH);
                viewItem.SubItems.Add(item.NgayBD.ToString());
                viewItem.SubItems.Add(item.NgayKT.ToString());
                viewItem.SubItems.Add(item.NoiCap);
                viewItem.SubItems.Add(item.GhiChu);
            }
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            OnLoadListView();
        }

        private void BaoHienNhanVien_Load(object sender, EventArgs e)
        {
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();

            comboBoxMaBaoHiem.Items.Clear();
            baoHiemList = _baoHiemDAO.GetAll();
            comboBoxMaBaoHiem.DataSource = baoHiemList;
            comboBoxMaBaoHiem.ValueMember = "MaBH";
            comboBoxMaBaoHiem.DisplayMember = "MaBH";

            comboBoxMaBaoHiem.Text = "";
            
        }

        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMaNhanVien.Text = listPage.SelectedItems[0].SubItems[0].Text;
                comboBoxMaBaoHiem.Text = listPage.SelectedItems[0].SubItems[2].Text;
                dateTimePickerNgayBd.Text = listPage.SelectedItems[0].SubItems[4].Text;
                dateTimePickerNgayKt.Text = listPage.SelectedItems[0].SubItems[5].Text;
                textBoxNoiCap.Text = listPage.SelectedItems[0].SubItems[6].Text;
                textBoxGhichu.Text = listPage.SelectedItems[0].SubItems[7].Text;
            }
        }
        //Load data vào list view
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            baoHiemVienNhanList = _baoHiemNhanVienDAO.GetAll();
            foreach (var item in baoHiemVienNhanList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.MaBH);
                viewItem.SubItems.Add(item.TenBH);
                viewItem.SubItems.Add(item.NgayBD.ToString());
                viewItem.SubItems.Add(item.NgayKT.ToString());
                viewItem.SubItems.Add(item.NoiCap);
                viewItem.SubItems.Add(item.GhiChu);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(comboBoxMaBaoHiem.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiêm");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxNoiCap.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nơi cấp");
                return;
            }

            if (_baoHiemNhanVienDAO.Insert(new Model.BaoHiemNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                MaBH = comboBoxMaBaoHiem.Text,
                NoiCap = textBoxNoiCap.Text,
                GhiChu = textBoxGhichu.Text,
                NgayBD = DateTime.Parse(dateTimePickerNgayBd.Value.ToShortDateString()),
                NgayKT = DateTime.Parse(dateTimePickerNgayKt.Value.ToShortDateString()),
            }))
            {
                OnLoadListView();
                textBoxMaNhanVien.Text = "";
                comboBoxMaBaoHiem.Text = "";
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

            if (String.IsNullOrWhiteSpace(comboBoxMaBaoHiem.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiêm");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxNoiCap.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nơi cấp");
                return;
            }

            if (_baoHiemNhanVienDAO.Update(new Model.BaoHiemNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                MaBH = comboBoxMaBaoHiem.Text,
                NoiCap = textBoxNoiCap.Text,
                GhiChu = textBoxGhichu.Text,
                NgayBD = DateTime.Parse(dateTimePickerNgayBd.Value.ToShortDateString()),
                NgayKT = DateTime.Parse(dateTimePickerNgayKt.Value.ToShortDateString()),
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
                return;
            }

            if (!String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                if (_baoHiemNhanVienDAO.Delete(textBoxMaNhanVien.Text, comboBoxMaBaoHiem.Text))
                {
                    OnLoadListView();
                    textBoxMaNhanVien.Text = "";
                    comboBoxMaBaoHiem.Text = "";
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
