using QuanLyNhanSu.UI.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            QuanLyNhanVien nhanVien = new QuanLyNhanVien();
            addUserControl(nhanVien);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien control = new QuanLyNhanVien();
            addUserControl(control);
        }

        private void bảngCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangCong control = new BangCong();
            addUserControl(control);
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongBan control = new PhongBan();
            addUserControl(control);
        }

        private void trìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrinhDo control = new TrinhDo();
            addUserControl(control);
        }

        private void ngoạiNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NgoaiNgu control = new NgoaiNgu();
            addUserControl(control);
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu control = new ChucVu();
            addUserControl(control);
        }

        private void chếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheDo control = new CheDo();
            addUserControl(control);
        }

        private void bảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoHiem control = new BaoHiem();
            addUserControl(control);
        }

        private void bậcLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BacLuong control = new BacLuong();
            addUserControl(control);
        }

        private void chứcVụNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVuNhanVien control = new ChucVuNhanVien();
            addUserControl(control);
        }

        private void ngoạiNgữNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NgoaiNguNhanVien control = new NgoaiNguNhanVien();
            addUserControl(control);
        }

        private void chếĐộNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheDoNhanVien control = new CheDoNhanVien();
            addUserControl(control);
        }

        private void bảoHiểmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoHienNhanVien control = new BaoHienNhanVien();
            addUserControl(control);
        }

        private void châmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCong control = new ChamCong();
            addUserControl(control);
        }
    }
}
