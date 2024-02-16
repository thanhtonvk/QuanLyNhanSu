using QuanLyNhanSu.DAO;
using QuanLyNhanSu.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSu.UI.Control
{
    public partial class QuanLyNhanVien : UserControl
    {
        private PhongBanDAO _phongBanDAO = new PhongBanDAO();
        private List<Model.PhongBan> phongBanList = new List<Model.PhongBan>();

        private TrinhDoDAO _trinhDoDAO = new TrinhDoDAO();
        private List<Model.TrinhDo> trinhDoList = new List<Model.TrinhDo>();

        private BacLuongDAO _bacLuongDAO = new BacLuongDAO();
        private List<Model.BacLuong> bacLuongList = new List<Model.BacLuong>();

        private NhanVienDAO _nhanVienDAO = new NhanVienDAO();
        private List<Model.NhanVien> nhanVienList = new List<Model.NhanVien>();

        private int isNam = 0;
        private string pathImage = string.Empty;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {


            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();


            comboBoxMaPhongBan.Items.Clear();
            phongBanList = _phongBanDAO.GetAll();
            comboBoxMaPhongBan.DataSource = phongBanList;
            comboBoxMaPhongBan.ValueMember = "MaPB";
            comboBoxMaPhongBan.DisplayMember = "MaPB";

            comboBoxMaTrinhDo.Items.Clear();
            trinhDoList = _trinhDoDAO.GetAll();
            comboBoxMaTrinhDo.DataSource = trinhDoList;
            comboBoxMaTrinhDo.ValueMember = "MaTD";
            comboBoxMaTrinhDo.DisplayMember = "MaTD";

            comboBoxMaBacLuong.Items.Clear();
            bacLuongList = _bacLuongDAO.GetAll();
            comboBoxMaBacLuong.DataSource = bacLuongList;
            comboBoxMaBacLuong.ValueMember = "MaBL";
            comboBoxMaBacLuong.DisplayMember = "MaBL";


            comboBoxMaPhongBan.Text = "";
            comboBoxMaTrinhDo.Text = "";
            comboBoxMaBacLuong.Text = "";


            Model.PhongBan objPb = comboBoxMaPhongBan.SelectedItem as Model.PhongBan;
            if (objPb != null) { labelTenPhonBan.Text = "Tên phòng ban: " + "trống"; }

            Model.TrinhDo objTd = comboBoxMaTrinhDo.SelectedItem as Model.TrinhDo;
            if (objTd != null) { labelTenTrinhDo.Text = "Tên trình độ: " + "trống"; }

            Model.BacLuong objBl = comboBoxMaBacLuong.SelectedItem as Model.BacLuong;
            if (objBl != null) { labelTenBacLuong.Text = "Tên bậc lương: " + "trống"; }


        }
        //Load data vào list view
        public void OnLoadListView()
        {
            listPage.Items.Clear();
            nhanVienList = _nhanVienDAO.GetAll();

            foreach (var item in nhanVienList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.NgaySinh.ToString());
                viewItem.SubItems.Add(item.DiaChi);
                viewItem.SubItems.Add(item.GioiTinh == 0 ? "Nam" : "Nữ");

                viewItem.SubItems.Add(item.SoCCCD);
                viewItem.SubItems.Add(item.NgayCap.ToString());
                viewItem.SubItems.Add(item.NoiCap);
                viewItem.SubItems.Add(item.SDTRieng);
                viewItem.SubItems.Add(item.SDTNha);
                viewItem.SubItems.Add(item.TinhTrangHonNhan);

                viewItem.SubItems.Add(item.MaPB);
                viewItem.SubItems.Add(item.MaTD);
                viewItem.SubItems.Add(item.MaBL);
            }
        }
        private void comboBoxMaPhongBan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Model.PhongBan obj = comboBoxMaPhongBan.SelectedItem as Model.PhongBan;
            if (obj != null) { labelTenPhonBan.Text = "Tên phòng ban: " + obj.TenPB; }
        }

        private void comboBoxMaTrinhDo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Model.TrinhDo obj = comboBoxMaTrinhDo.SelectedItem as Model.TrinhDo;
            if (obj != null) { labelTenTrinhDo.Text = "Tên trình độ: " + obj.TenTD; }
        }

        private void comboBoxMaBacLuong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Model.BacLuong obj = comboBoxMaBacLuong.SelectedItem as Model.BacLuong;
            if (obj != null) { labelTenBacLuong.Text = "Tên bậc lương: " + obj.TenBL; }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxTenNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống tên nhân viên");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxDiaChi.Text))
            {
                MessageBox.Show("Không được bỏ trống địa chỉ");
                return;
            }

            if (String.IsNullOrWhiteSpace(comboBoxMaPhongBan.Text))
            {
                MessageBox.Show("Không được bỏ trống mã phòng ban");
                return;
            }
            if (String.IsNullOrWhiteSpace(comboBoxMaBacLuong.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bậc lương");
                return;
            }
            if (String.IsNullOrWhiteSpace(comboBoxMaTrinhDo.Text))
            {
                MessageBox.Show("Không được bỏ trống mã trình độ");
                return;
            }
            if (String.IsNullOrWhiteSpace(pathImage))
            {
                MessageBox.Show("Hình ảnh không được để trống");
                return;
            }

            if (_nhanVienDAO.Insert(new Model.NhanVien()
            {

                MaNV = textBoxMaNhanVien.Text,
                TenNV = textBoxTenNhanVien.Text,
                NgaySinh = DateTime.Parse(dateTimePickerNgaySinh.Value.ToShortDateString()),
                DiaChi = textBoxDiaChi.Text,
                GioiTinh = isNam,
                MaPB = comboBoxMaPhongBan.Text,
                MaTD = comboBoxMaTrinhDo.Text,
                MaBL = comboBoxMaBacLuong.Text,
                HinhAnh = pathImage,
                SoCCCD = SoCCCD.Text,
                NgayCap = DateTime.Parse(NgayCap.Value.ToShortDateString()),
                NoiCap = NoiCap.Text,
                SDTRieng = SDTRieng.Text,
                SDTNha = SDTNha.Text,
                TinhTrangHonNhan = TinhTrangHonNhan.Text,
            }))
            {
                OnLoadListView();
                textBoxMaNhanVien.Text = "";
                textBoxTenNhanVien.Text = "";
                textBoxDiaChi.Text = "";
                isNam = 0;
                comboBoxMaPhongBan.Text = "";
                comboBoxMaTrinhDo.Text = "";
                comboBoxMaBacLuong.Text = "";
                labelTenPhonBan.Text = "";
                labelTenTrinhDo.Text = "";
                labelTenBacLuong.Text = "";
                SoCCCD.Text = "";
                TinhTrangHonNhan.Text = "";
                NoiCap.Text = "";
                SDTRieng.Text = "";
                SDTNha.Text = "";
                imageNv.Image = null;
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isNam = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isNam = 1;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxTenNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống tên nhân viên");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxDiaChi.Text))
            {
                MessageBox.Show("Không được bỏ trống địa chỉ");
                return;
            }

            if (String.IsNullOrWhiteSpace(comboBoxMaPhongBan.Text))
            {
                MessageBox.Show("Không được bỏ trống mã phòng ban");
                return;
            }
            if (String.IsNullOrWhiteSpace(comboBoxMaBacLuong.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bậc lương");
                return;
            }
            if (String.IsNullOrWhiteSpace(comboBoxMaTrinhDo.Text))
            {
                MessageBox.Show("Không được bỏ trống mã trình độ");
                return;
            }
          
            if (_nhanVienDAO.Update(new Model.NhanVien()
            {

                MaNV = textBoxMaNhanVien.Text,
                TenNV = textBoxTenNhanVien.Text,
                NgaySinh = DateTime.Parse(dateTimePickerNgaySinh.Value.ToShortDateString()),
                DiaChi = textBoxDiaChi.Text,
                GioiTinh = isNam,
                MaPB = comboBoxMaPhongBan.Text,
                MaTD = comboBoxMaTrinhDo.Text,
                MaBL = comboBoxMaBacLuong.Text,
                HinhAnh = pathImage,
                SoCCCD = SoCCCD.Text,
                NgayCap = DateTime.Parse(NgayCap.Value.ToShortDateString()),
                NoiCap = NoiCap.Text,
                SDTRieng = SDTRieng.Text,
                SDTNha = SDTNha.Text,
                TinhTrangHonNhan = TinhTrangHonNhan.Text,
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
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (!String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                if (_nhanVienDAO.Delete(textBoxMaNhanVien.Text))
                {
                    OnLoadListView();
                    textBoxMaNhanVien.Text = "";
                    textBoxTenNhanVien.Text = "";
                    textBoxDiaChi.Text = "";
                    isNam = 0;
                    comboBoxMaPhongBan.Text = "";
                    comboBoxMaTrinhDo.Text = "";
                    comboBoxMaBacLuong.Text = "";
                    labelTenPhonBan.Text = "";
                    labelTenTrinhDo.Text = "";
                    labelTenBacLuong.Text = "";
                    SoCCCD.Text = "";
                    TinhTrangHonNhan.Text = "";
                    NoiCap.Text = "";
                    SDTRieng.Text = "";
                    SDTNha.Text = "";
                    imageNv.Image = null;
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

                NhanVien nhanVien = _nhanVienDAO.GetNV(listPage.SelectedItems[0].SubItems[0].Text);
                LoadImageFromByteArray(nhanVien.HinhAnh);

                textBoxMaNhanVien.Text = nhanVien.MaNV;
                textBoxTenNhanVien.Text = nhanVien.TenNV;
                dateTimePickerNgaySinh.Text = nhanVien.NgaySinh.ToString();
                textBoxDiaChi.Text = nhanVien.DiaChi;
                if (listPage.SelectedItems[0].SubItems[4].Text == "Nam")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                comboBoxMaPhongBan.Text = nhanVien.MaPB;
                comboBoxMaTrinhDo.Text = nhanVien.MaTD;
                comboBoxMaBacLuong.Text = nhanVien.MaBL;

                SoCCCD.Text = nhanVien.SoCCCD;
                NoiCap.Text = nhanVien.NoiCap;
                SDTRieng.Text = nhanVien.SDTRieng;
                SDTNha.Text = nhanVien.SDTNha;
                TinhTrangHonNhan.Text = nhanVien.TinhTrangHonNhan;
                NgayCap.Text = nhanVien.NgayCap.ToString();

            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            nhanVienList.Clear();
            listPage.Items.Clear();
            nhanVienList = _nhanVienDAO.Get(textBoxTimKiem.Text);
            foreach (var item in nhanVienList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.NgaySinh.ToString());
                viewItem.SubItems.Add(item.DiaChi);
                viewItem.SubItems.Add(item.GioiTinh == 0 ? "Nam" : "Nữ");
                viewItem.SubItems.Add(item.MaPB);
                viewItem.SubItems.Add(item.MaTD);
                viewItem.SubItems.Add(item.MaBL);
            }
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            OnLoadListView();
        }

        private void addImage(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp PNG (*.png)|*.png|Tệp JPG (*.jpg)|*.jpg|Tất cả các tệp (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                string extension = Path.GetExtension(selectedFilePath).ToLower();

                if (extension == ".png" || extension == ".jpg")
                {
                    pathImage = selectedFilePath;
                    imageNv.Image = new Bitmap(selectedFilePath);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tệp PNG hoặc JPG hợp lệ.", "Loại Tệp Không Hợp Lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void LoadImageFromByteArray(string imagpath)
        {
            try
            {
                System.Drawing.Image loadedImage = System.Drawing.Image.FromFile(imagpath);
                imageNv.Image = loadedImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }
            else
            {
 
                NhanVien.ConstMaNV = textBoxMaNhanVien.Text;
                BangLuong bangLuong = new BangLuong();
                bangLuong.ShowDialog();
            }
        }

        private void imageNv_Click(object sender, EventArgs e)
        {

        }
    }
}
