using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.UI
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

        }
        private System.Windows.Forms.Timer aTimer;

        private int counter = 3;
        private void Start_Load(object sender, EventArgs e)
        {
            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(aTimer_Tick);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();


        }
        private void aTimer_Tick(object sender, EventArgs e)

        {

            counter--;

            if (counter == 0)
            {
                aTimer.Stop();
                Main main = new Main();
                this.Close();
                main.Show();

            }
                


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
