namespace QuanLyNhanSu.UI.Control
{
    partial class BaoHienNhanVien
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
            this.listPage = new System.Windows.Forms.ListView();
            this.MaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maCv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenCv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaybd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaykt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noicap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ghichu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerNgayKt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayBd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMaBaoHiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPhongBan = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxGhichu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNoiCap = new System.Windows.Forms.TextBox();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelPhongBan.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.ngaykt,
            this.noicap,
            this.ghichu});
            this.listPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPage.HideSelection = false;
            this.listPage.Location = new System.Drawing.Point(0, 0);
            this.listPage.Name = "listPage";
            this.listPage.Size = new System.Drawing.Size(1264, 516);
            this.listPage.TabIndex = 0;
            this.listPage.Tag = "";
            this.listPage.UseCompatibleStateImageBehavior = false;
            this.listPage.View = System.Windows.Forms.View.Details;
            this.listPage.SelectedIndexChanged += new System.EventHandler(this.listPage_SelectedIndexChanged);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Text = "Mã nhân viên";
            this.MaNhanVien.Width = 82;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Text = "Tên nhân viên";
            this.TenNhanVien.Width = 126;
            // 
            // maCv
            // 
            this.maCv.Text = "Mã chức vụ";
            this.maCv.Width = 111;
            // 
            // tenCv
            // 
            this.tenCv.Text = "Tên chức vụ";
            this.tenCv.Width = 150;
            // 
            // ngaybd
            // 
            this.ngaybd.Text = "Ngày bắt đầu";
            this.ngaybd.Width = 111;
            // 
            // ngaykt
            // 
            this.ngaykt.Text = "Ngày kết thúc";
            this.ngaykt.Width = 129;
            // 
            // noicap
            // 
            this.noicap.Text = "Nơi cấp";
            // 
            // ghichu
            // 
            this.ghichu.Text = "Ghi chú";
            // 
            // dateTimePickerNgayKt
            // 
            this.dateTimePickerNgayKt.Location = new System.Drawing.Point(359, 69);
            this.dateTimePickerNgayKt.Name = "dateTimePickerNgayKt";
            this.dateTimePickerNgayKt.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayKt.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(271, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày kết thúc";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(274, 94);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(346, 38);
            this.textBoxTimKiem.TabIndex = 26;
            // 
            // dateTimePickerNgayBd
            // 
            this.dateTimePickerNgayBd.Location = new System.Drawing.Point(359, 43);
            this.dateTimePickerNgayBd.Name = "dateTimePickerNgayBd";
            this.dateTimePickerNgayBd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayBd.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(271, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã bảo hiểm";
            // 
            // comboBoxMaBaoHiem
            // 
            this.comboBoxMaBaoHiem.FormattingEnabled = true;
            this.comboBoxMaBaoHiem.Location = new System.Drawing.Point(100, 69);
            this.comboBoxMaBaoHiem.Name = "comboBoxMaBaoHiem";
            this.comboBoxMaBaoHiem.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMaBaoHiem.TabIndex = 14;
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
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bảo hiểm nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPhongBan
            // 
            this.panelPhongBan.Controls.Add(this.listPage);
            this.panelPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPhongBan.Location = new System.Drawing.Point(0, 141);
            this.panelPhongBan.Name = "panelPhongBan";
            this.panelPhongBan.Size = new System.Drawing.Size(1264, 516);
            this.panelPhongBan.TabIndex = 8;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.textBoxGhichu);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label6);
            this.panelMenu.Controls.Add(this.textBoxNoiCap);
            this.panelMenu.Controls.Add(this.dateTimePickerNgayKt);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.buttonLamMoi);
            this.panelMenu.Controls.Add(this.buttonTimKiem);
            this.panelMenu.Controls.Add(this.textBoxTimKiem);
            this.panelMenu.Controls.Add(this.dateTimePickerNgayBd);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.comboBoxMaBaoHiem);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMaNhanVien);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 135);
            this.panelMenu.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.rotation;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(100, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 38;
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
            this.button2.Location = new System.Drawing.Point(201, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 43);
            this.button2.TabIndex = 37;
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
            this.button3.Location = new System.Drawing.Point(-1, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 41);
            this.button3.TabIndex = 36;
            this.button3.Text = "Thêm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxGhichu
            // 
            this.textBoxGhichu.Location = new System.Drawing.Point(659, 65);
            this.textBoxGhichu.Name = "textBoxGhichu";
            this.textBoxGhichu.Size = new System.Drawing.Size(165, 20);
            this.textBoxGhichu.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(575, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(572, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nơi cấp";
            // 
            // textBoxNoiCap
            // 
            this.textBoxNoiCap.Location = new System.Drawing.Point(659, 40);
            this.textBoxNoiCap.Name = "textBoxNoiCap";
            this.textBoxNoiCap.Size = new System.Drawing.Size(165, 20);
            this.textBoxNoiCap.TabIndex = 31;
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLamMoi.Image = global::QuanLyNhanSu.Properties.Resources.circular_arrow;
            this.buttonLamMoi.Location = new System.Drawing.Point(675, 94);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(42, 38);
            this.buttonLamMoi.TabIndex = 28;
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.White;
            this.buttonTimKiem.Image = global::QuanLyNhanSu.Properties.Resources.search;
            this.buttonTimKiem.Location = new System.Drawing.Point(626, 94);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(43, 38);
            this.buttonTimKiem.TabIndex = 27;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(723, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 34);
            this.button4.TabIndex = 61;
            this.button4.Text = "Xuất danh sách ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BaoHienNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPhongBan);
            this.Controls.Add(this.panelMenu);
            this.Name = "BaoHienNhanVien";
            this.Size = new System.Drawing.Size(1264, 657);
            this.Load += new System.EventHandler(this.BaoHienNhanVien_Load);
            this.panelPhongBan.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPage;
        private System.Windows.Forms.ColumnHeader MaNhanVien;
        private System.Windows.Forms.ColumnHeader TenNhanVien;
        private System.Windows.Forms.ColumnHeader maCv;
        private System.Windows.Forms.ColumnHeader tenCv;
        private System.Windows.Forms.ColumnHeader ngaybd;
        private System.Windows.Forms.ColumnHeader ngaykt;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMaBaoHiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPhongBan;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNoiCap;
        private System.Windows.Forms.TextBox textBoxGhichu;
        private System.Windows.Forms.ColumnHeader noicap;
        private System.Windows.Forms.ColumnHeader ghichu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
