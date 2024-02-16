namespace QuanLyNhanSu.UI.Control
{
    partial class NgoaiNguNhanVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayCap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ngayCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenCv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maNN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelPhongBan = new System.Windows.Forms.Panel();
            this.listPage = new System.Windows.Forms.ListView();
            this.panelMenu.SuspendLayout();
            this.panelPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.textBoxTimKiem);
            this.panelMenu.Controls.Add(this.dateTimePickerNgayCap);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.comboBoxMa);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMaNhanVien);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 130);
            this.panelMenu.TabIndex = 7;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::QuanLyNhanSu.Properties.Resources.circular_arrow;
            this.button4.Location = new System.Drawing.Point(686, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 38);
            this.button4.TabIndex = 47;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Image = global::QuanLyNhanSu.Properties.Resources.search;
            this.button5.Location = new System.Drawing.Point(637, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 38);
            this.button5.TabIndex = 46;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.rotation;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(100, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 45;
            this.button1.Text = "Cập nhật";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Image = global::QuanLyNhanSu.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(201, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 37);
            this.button2.TabIndex = 44;
            this.button2.Text = "Xóa ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Image = global::QuanLyNhanSu.Properties.Resources.add__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-1, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 37);
            this.button3.TabIndex = 43;
            this.button3.Text = "Thêm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(285, 95);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(346, 36);
            this.textBoxTimKiem.TabIndex = 26;
            // 
            // dateTimePickerNgayCap
            // 
            this.dateTimePickerNgayCap.Location = new System.Drawing.Point(359, 40);
            this.dateTimePickerNgayCap.Name = "dateTimePickerNgayCap";
            this.dateTimePickerNgayCap.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayCap.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(271, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày cấp";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã ngoại ngữ";
            // 
            // comboBoxMa
            // 
            this.comboBoxMa.FormattingEnabled = true;
            this.comboBoxMa.Location = new System.Drawing.Point(100, 69);
            this.comboBoxMa.Name = "comboBoxMa";
            this.comboBoxMa.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMa.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã nhân viên";
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(100, 40);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(165, 20);
            this.textBoxMaNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngoại ngữ nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ngayCap
            // 
            this.ngayCap.Text = "Ngày cấp";
            this.ngayCap.Width = 111;
            // 
            // tenCv
            // 
            this.tenCv.Text = "Tên ngoại ngữ";
            this.tenCv.Width = 150;
            // 
            // maNN
            // 
            this.maNN.Text = "Mã ngoại ngữ";
            this.maNN.Width = 111;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Text = "Mã nhân viên";
            this.MaNhanVien.Width = 82;
            // 
            // panelPhongBan
            // 
            this.panelPhongBan.Controls.Add(this.listPage);
            this.panelPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPhongBan.Location = new System.Drawing.Point(0, 136);
            this.panelPhongBan.Name = "panelPhongBan";
            this.panelPhongBan.Size = new System.Drawing.Size(1264, 521);
            this.panelPhongBan.TabIndex = 6;
            // 
            // listPage
            // 
            this.listPage.AccessibleName = "";
            this.listPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhanVien,
            this.maNN,
            this.tenCv,
            this.ngayCap});
            this.listPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPage.HideSelection = false;
            this.listPage.Location = new System.Drawing.Point(0, 0);
            this.listPage.Name = "listPage";
            this.listPage.Size = new System.Drawing.Size(1264, 521);
            this.listPage.TabIndex = 0;
            this.listPage.Tag = "";
            this.listPage.UseCompatibleStateImageBehavior = false;
            this.listPage.View = System.Windows.Forms.View.Details;
            this.listPage.SelectedIndexChanged += new System.EventHandler(this.listPage_SelectedIndexChanged);
            // 
            // NgoaiNguNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPhongBan);
            this.Name = "NgoaiNguNhanVien";
            this.Size = new System.Drawing.Size(1264, 657);
            this.Load += new System.EventHandler(this.NgoaiNguNhanVien_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayCap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ngayCap;
        private System.Windows.Forms.ColumnHeader tenCv;
        private System.Windows.Forms.ColumnHeader maNN;
        private System.Windows.Forms.ColumnHeader MaNhanVien;
        private System.Windows.Forms.Panel panelPhongBan;
        private System.Windows.Forms.ListView listPage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
