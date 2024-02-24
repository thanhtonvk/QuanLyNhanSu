using ArrayToExcel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.Model;
using QuanLyVatTu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NsExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhanSu.UI
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienDAO dao = new NhanVienDAO();
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            var ds = dao.GetAll();
            dataGridView1.DataSource = ds;
           

        }

        public void toExcel()
        {
            //start excel
            var excel = dao.GetAll().ToExcel();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("Excel File|*.xlsx");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, excel);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            toExcel();
        }
    }
}
