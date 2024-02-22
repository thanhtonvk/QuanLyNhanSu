using QuanLyNhanSu.DAO;
using QuanLyVatTu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.UI
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NhanVienDAO dao = new NhanVienDAO();
            var ds = dao.GetAll();
            dataGridView1.DataSource = ds;
           

        }
        ScreenCapture capScreen = new ScreenCapture();
        Bitmap memoryImage;
        private void printDocument1_PrintPage(System.Object sender,
  System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();


            try
            {
                memoryImage = capScreen.Capture(CaptureMode.Window);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }
    }
}
