namespace QuanLyNhanSu.UI.Control
{
    partial class CheDoNhanVien
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
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerNgayKt = new System.Windows.Forms.DateTimePicker();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayBd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMaCheDo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ngaykt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaybd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenCv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maCv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelPhongBan = new System.Windows.Forms.Panel();
            this.listPage = new System.Windows.Forms.ListView();
            this.button6 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(271, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày kết thúc";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.dateTimePickerNgayKt);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.textBoxTimKiem);
            this.panelMenu.Controls.Add(this.dateTimePickerNgayBd);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.comboBoxMaCheDo);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMaNhanVien);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1000, 135);
            this.panelMenu.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::QuanLyNhanSu.Properties.Resources.circular_arrow;
            this.button4.Location = new System.Drawing.Point(704, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 38);
            this.button4.TabIndex = 43;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Image = global::QuanLyNhanSu.Properties.Resources.search;
            this.button5.Location = new System.Drawing.Point(655, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 38);
            this.button5.TabIndex = 42;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.rotation;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(105, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 33;
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
            this.button2.Location = new System.Drawing.Point(206, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 37);
            this.button2.TabIndex = 32;
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
            this.button3.Location = new System.Drawing.Point(4, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 31;
            this.button3.Text = "Thêm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePickerNgayKt
            // 
            this.dateTimePickerNgayKt.Location = new System.Drawing.Point(359, 66);
            this.dateTimePickerNgayKt.Name = "dateTimePickerNgayKt";
            this.dateTimePickerNgayKt.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayKt.TabIndex = 30;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(303, 99);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(346, 36);
            this.textBoxTimKiem.TabIndex = 26;
            // 
            // dateTimePickerNgayBd
            // 
            this.dateTimePickerNgayBd.Location = new System.Drawing.Point(359, 40);
            this.dateTimePickerNgayBd.Name = "dateTimePickerNgayBd";
            this.dateTimePickerNgayBd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayBd.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(271, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã chế độ";
            // 
            // comboBoxMaCheDo
            // 
            this.comboBoxMaCheDo.FormattingEnabled = true;
            this.comboBoxMaCheDo.Location = new System.Drawing.Point(100, 69);
            this.comboBoxMaCheDo.Name = "comboBoxMaCheDo";
            this.comboBoxMaCheDo.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMaCheDo.TabIndex = 14;
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
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chế độ nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ngaykt
            // 
            this.ngaykt.Text = "Ngày kết thúc";
            this.ngaykt.Width = 129;
            // 
            // ngaybd
            // 
            this.ngaybd.Text = "Ngày bắt đầu";
            this.ngaybd.Width = 111;
            // 
            // tenCv
            // 
            this.tenCv.Text = "Tên chức vụ";
            this.tenCv.Width = 150;
            // 
            // maCv
            // 
            this.maCv.Text = "Mã chức vụ";
            this.maCv.Width = 111;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Text = "Tên nhân viên";
            this.TenNhanVien.Width = 126;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Text = "Mã nhân viên";
            this.MaNhanVien.Width = 82;
            // 
            // panelPhongBan
            // 
            this.panelPhongBan.Controls.Add(this.listPage);
            this.panelPhongBan.Location = new System.Drawing.Point(0, 141);
            this.panelPhongBan.Name = "panelPhongBan";
            this.panelPhongBan.Size = new System.Drawing.Size(994, 356);
            this.panelPhongBan.TabIndex = 6;
            // 
            // listPage
            // 
            this.listPage.AccessibleName = "";
            this.listPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.maCv,
            this.tenCv,
            this.ngaybd,
            this.ngaykt});
            this.listPage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPage.HideSelection = false;
            this.listPage.Location = new System.Drawing.Point(0, 0);
            this.listPage.Name = "listPage";
            this.listPage.Size = new System.Drawing.Size(994, 359);
            this.listPage.TabIndex = 0;
            this.listPage.Tag = "";
            this.listPage.UseCompatibleStateImageBehavior = false;
            this.listPage.View = System.Windows.Forms.View.Details;
            this.listPage.SelectedIndexChanged += new System.EventHandler(this.listPage_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(752, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 34);
            this.button6.TabIndex = 61;
            this.button6.Text = "Xuất danh sách ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CheDoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPhongBan);
            this.Name = "CheDoNhanVien";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.CheDoNhanVien_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKt;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMaCheDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ngaykt;
        private System.Windows.Forms.ColumnHeader ngaybd;
        private System.Windows.Forms.ColumnHeader tenCv;
        private System.Windows.Forms.ColumnHeader maCv;
        private System.Windows.Forms.ColumnHeader TenNhanVien;
        private System.Windows.Forms.ColumnHeader MaNhanVien;
        private System.Windows.Forms.Panel panelPhongBan;
        private System.Windows.Forms.ListView listPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
