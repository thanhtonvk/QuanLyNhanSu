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
    public partial class CheDoNhanVien : UserControl
    {
        private CheDoDAO _cheDoDAO = new CheDoDAO();
        private List<Model.CheDo> cheDoList = new List<Model.CheDo>();

        private CheDoNhanVienDAO _cheDoNhanVienDAO = new CheDoNhanVienDAO();
        private List<Model.CheDoNhanVien> cheDoVienNhanList = new List<Model.CheDoNhanVien>();
        public CheDoNhanVien()
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
                comboBoxMaCheDo.Text = listPage.SelectedItems[0].SubItems[2].Text;
                dateTimePickerNgayBd.Text = listPage.SelectedItems[0].SubItems[4].Text;
                dateTimePickerNgayKt.Text = listPage.SelectedItems[0].SubItems[5].Text;
            }
        }
        //Load data vào list view
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            cheDoVienNhanList = _cheDoNhanVienDAO.GetAll();
            foreach (var item in cheDoVienNhanList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.MaCD);
                viewItem.SubItems.Add(item.TenCD);
                viewItem.SubItems.Add(item.NgayBD.ToString());
                viewItem.SubItems.Add(item.NgayKT.ToString());
            }
        }

        private void CheDoNhanVien_Load(object sender, EventArgs e)
        {
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();

            comboBoxMaCheDo.Items.Clear();
            cheDoList = _cheDoDAO.GetAll();
            comboBoxMaCheDo.DataSource = cheDoList;
            comboBoxMaCheDo.ValueMember = "MaCD";
            comboBoxMaCheDo.DisplayMember = "MaCD";

            comboBoxMaCheDo.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMaNhanVien.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                return;
            }

            if (String.IsNullOrWhiteSpace(comboBoxMaCheDo.Text))
            {
                MessageBox.Show("Không được bỏ trống mã chế độ");
                return;
            }


            if (_cheDoNhanVienDAO.Insert(new Model.CheDoNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                MaCD = comboBoxMaCheDo.Text,
                NgayBD = DateTime.Parse(dateTimePickerNgayBd.Value.ToShortDateString()),
                NgayKT = DateTime.Parse(dateTimePickerNgayKt.Value.ToShortDateString()),
            }))
            {
                OnLoadListView();
                textBoxMaNhanVien.Text = "";
                comboBoxMaCheDo.Text = "";
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

            if (String.IsNullOrWhiteSpace(comboBoxMaCheDo.Text))
            {
                MessageBox.Show("Không được bỏ trống mã chế độ");
                return;
            }


            if (_cheDoNhanVienDAO.Update(new Model.CheDoNhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                NgayBD = DateTime.Parse(dateTimePickerNgayBd.Value.ToShortDateString()),
                NgayKT = DateTime.Parse(dateTimePickerNgayKt.Value.ToShortDateString()),
                MaCD = comboBoxMaCheDo.Text,
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
                if (_cheDoNhanVienDAO.Delete(textBoxMaNhanVien.Text, comboBoxMaCheDo.Text))
                {
                    OnLoadListView();
                    textBoxMaNhanVien.Text = "";
                    comboBoxMaCheDo.Text = "";
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
            cheDoVienNhanList.Clear();
            listPage.Items.Clear();
            cheDoVienNhanList = _cheDoNhanVienDAO.Get(textBoxTimKiem.Text);
            foreach (var item in cheDoVienNhanList)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaNV);
                viewItem.SubItems.Add(item.TenNV);
                viewItem.SubItems.Add(item.MaCD);
                viewItem.SubItems.Add(item.TenCD);
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
