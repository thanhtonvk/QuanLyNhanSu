using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSu.UI.Control
{
    public partial class ChamCong : UserControl
    {
        private ChamCongDAO _dao = new ChamCongDAO();
        private NhanVienDAO _daoNV = new NhanVienDAO();
        private List<Model.ChamCong> list = new List<Model.ChamCong>();

        private int maCC = 0;
        public ChamCong()
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
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (_dao.Delete(maCC))
            {
                OnLoadListView();
                textGhiChu.Text = "";
                textBoxMaNhanVien.Text = "";
                textGioVao.Text = "";
                textGioRa.Text = "";
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                maCC = int.Parse(listPage.SelectedItems[0].SubItems[0].Text);
                textBoxMaNhanVien.Text = listPage.SelectedItems[0].SubItems[1].Text;
                dateTimePickerNgayCC.Text = listPage.SelectedItems[0].SubItems[2].Text;
                textGioVao.Text = listPage.SelectedItems[0].SubItems[3].Text;
                textGioRa.Text = listPage.SelectedItems[0].SubItems[4].Text;
                textGhiChu.Text = listPage.SelectedItems[0].SubItems[5].Text;
            }
        }
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            list = _dao.GetAll();
            foreach (var item in list)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaCC.ToString());
                viewItem.SubItems.Add(item.MaNV);
                viewItem.SubItems.Add(item.NgayCham.ToString());
                viewItem.SubItems.Add(item.Checkin.ToString());
                viewItem.SubItems.Add(item.Checkout.ToString());
                viewItem.SubItems.Add(item.GhiChu.ToString());
            }
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {

            listPage.Columns[0].Width = (int)(listPage.Width * 0.25);
            listPage.Columns[1].Width = (int)(listPage.Width * 0.25);
            listPage.Columns[2].Width = (int)(listPage.Width * 0.25);
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(_daoNV.GetNV(textBoxMaNhanVien.Text).TenNV))
            {
                MessageBox.Show("Mã nhân viên này ko tồn tại");
                return;
            }

            if (String.IsNullOrWhiteSpace(textGioVao.Text))
            {
                MessageBox.Show("Không được bỏ trống giờ vào");
                return;
            }
            if (String.IsNullOrWhiteSpace(textGioRa.Text))
            {
                MessageBox.Show("Không được bỏ trống giờ ra");
                return;
            }
            TimeSpan timeSpanGioVao;
            TimeSpan timeSpanGioRa;


            try
            {
                DateTime parsedTime = DateTime.ParseExact(textGioVao.Text, "HH:mm:ss", null);

                timeSpanGioVao = TimeSpan.Parse(textGioVao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giờ vào.Vd: 12:30:45");
                return;
            }

            try
            {
                DateTime parsedTime = DateTime.ParseExact(textGioRa.Text, "HH:mm:ss", null);

                timeSpanGioRa = TimeSpan.Parse(textGioRa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giờ ra.Vd: 12:30:45");
                return;
            }

            if (_dao.Insert(new Model.ChamCong()
            {
                MaCC = 0,
                MaNV = textBoxMaNhanVien.Text,
                NgayCham = DateTime.Parse(dateTimePickerNgayCC.Value.ToShortDateString()),

                Checkin = timeSpanGioVao,
                Checkout = timeSpanGioRa,
                GhiChu = textGhiChu.Text,
            }))
            {
                OnLoadListView();

                textGhiChu.Text = "";
                textBoxMaNhanVien.Text = "";
                textGioVao.Text = "";
                textGioRa.Text = "";

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
            if (String.IsNullOrWhiteSpace(_daoNV.GetNV(textBoxMaNhanVien.Text).TenNV))
            {
                MessageBox.Show("Mã nhân viên này ko tồn tại");
                return;
            }

            if (String.IsNullOrWhiteSpace(textGioVao.Text))
            {
                MessageBox.Show("Không được bỏ trống giờ vào");
                return;
            }
            if (String.IsNullOrWhiteSpace(textGioRa.Text))
            {
                MessageBox.Show("Không được bỏ trống giờ ra");
                return;
            }

            if (!TimeSpan.TryParse(textGioVao.Text, out TimeSpan timeSpan))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giờ.Vd: 12:30:45");
                return;
            }
            if (!TimeSpan.TryParse(textGioRa.Text, out TimeSpan timeSpan1))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giờ.Vd: 12:30:45");
                return;
            }
            TimeSpan timeSpanGioVao;
            TimeSpan timeSpanGioRa;


            try
            {
                DateTime parsedTime = DateTime.ParseExact(textGioVao.Text, "HH:mm:ss", null);

                timeSpanGioVao = TimeSpan.Parse(textGioVao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giờ vào.Vd: 12:30:45");
                return;
            }

            try
            {
                DateTime parsedTime = DateTime.ParseExact(textGioRa.Text, "HH:mm:ss", null);

                timeSpanGioRa = TimeSpan.Parse(textGioRa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giờ ra.Vd: 12:30:45");
                return;
            }

            if (_dao.Update(new Model.ChamCong()
            {
                MaCC = maCC,
                MaNV = textBoxMaNhanVien.Text,
                NgayCham = DateTime.Parse(dateTimePickerNgayCC.Value.ToShortDateString()),
                Checkin = timeSpanGioVao,
                Checkout = timeSpanGioRa,
                GhiChu = textGhiChu.Text,

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

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listPage.Items.Clear();
            list = _dao.GetAll().Where(x => x.MaNV.Contains(textBoxTimKiem.Text)).ToList();
            foreach (var item in list)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaCC.ToString());
                viewItem.SubItems.Add(item.MaNV);
                viewItem.SubItems.Add(item.NgayCham.ToString());
                viewItem.SubItems.Add(item.Checkin.ToString());
                viewItem.SubItems.Add(item.Checkout.ToString());
                viewItem.SubItems.Add(item.GhiChu.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnLoadListView();

        }
    }
}
