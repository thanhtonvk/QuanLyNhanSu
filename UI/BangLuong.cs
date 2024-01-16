using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace QuanLyNhanSu.UI

{
    public partial class BangLuong : Form
    {

        DataHandle _handle;
        PrintDocument printDocument1 = new PrintDocument();
        public BangLuong()
        {
            InitializeComponent();
            _handle = new DataHandle();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void BangLuong_Load(object sender, EventArgs e)
        {
            string query = $"select NhanVien.MaNV,TenNV,NhanVien.SDTRieng,PhongBan.TenPB,BacLuong.HeSBL,count(ChamCong.MaCC) [SoLuong],count(ChamCong.MaCC)*200000*BacLuong.HeSBL [SoTien] from NhanVien,PhongBan,BacLuong,ChamCong where NhanVien.MaPB = PhongBan.MaPB and NhanVien.MaBL = BacLuong.MaBL and NhanVien.MaNV = ChamCong.MaNV and MONTH(ChamCong.NgayCham) = MONTH(GETDATE()) and YEAR(ChamCong.NgayCham) = YEAR(GETDATE()) and NhanVien.MaNV = '{NhanVien.ConstMaNV}' group by NhanVien.MaNV,TenNV,NhanVien.SDTRieng,PhongBan.TenPB,BacLuong.HeSBL";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                manv.Text = row["MaNV"].ToString();
                sdt.Text = row["SDTRieng"].ToString();
                phongban.Text = row["TenPB"].ToString();
                hesoluong.Text = row["HeSBL"].ToString();
                soluong.Text = row["SoLuong"].ToString();
                sotien.Text = row["SoTien"].ToString();
            }
            ngaythang.Text = DateTime.Now.ToString();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {

            CaptureScreen();
            printDocument1.Print();
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(System.Object sender,
          System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
