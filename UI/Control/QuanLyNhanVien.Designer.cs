﻿namespace QuanLyNhanSu.UI.Control
{
    partial class QuanLyNhanVien
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
            System.Windows.Forms.ColumnHeader soccc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            this.listPage = new System.Windows.Forms.ListView();
            this.MaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mapb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mabl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NoiCap = new System.Windows.Forms.TextBox();
            this.SDTRieng = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SDTNha = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TinhTrangHonNhan = new System.Windows.Forms.TextBox();
            this.NgayCap = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.SoCCCD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.labelTenBacLuong = new System.Windows.Forms.Label();
            this.labelTenTrinhDo = new System.Windows.Forms.Label();
            this.labelTenPhonBan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMaBacLuong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMaTrinhDo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMaPhongBan = new System.Windows.Forms.ComboBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPhongBan = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.imageNv = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            soccc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelPhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNv)).BeginInit();
            this.SuspendLayout();
            // 
            // soccc
            // 
            soccc.Text = "Số CCCD ";
            // 
            // listPage
            // 
            this.listPage.AccessibleName = "";
            this.listPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.ngaySinh,
            this.diachi,
            this.gioitinh,
            soccc,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader5,
            this.mapb,
            this.matd,
            this.mabl});
            this.listPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPage.HideSelection = false;
            this.listPage.Location = new System.Drawing.Point(0, 0);
            this.listPage.Name = "listPage";
            this.listPage.Size = new System.Drawing.Size(1264, 413);
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
            this.TenNhanVien.Width = 157;
            // 
            // ngaySinh
            // 
            this.ngaySinh.Text = "Ngày sinh";
            this.ngaySinh.Width = 111;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa chỉ";
            this.diachi.Width = 123;
            // 
            // gioitinh
            // 
            this.gioitinh.Text = "Giới tính";
            this.gioitinh.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày cấp";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nơi cấp";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SDT riêng";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SDT Nhà ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TT hôn nhân";
            // 
            // mapb
            // 
            this.mapb.Text = "Mã phòng ban";
            this.mapb.Width = 82;
            // 
            // matd
            // 
            this.matd.Text = "Mã trình độ";
            this.matd.Width = 79;
            // 
            // mabl
            // 
            this.mabl.Text = "Mã bậc lương";
            this.mabl.Width = 106;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.imageNv);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.label15);
            this.panelMenu.Controls.Add(this.label12);
            this.panelMenu.Controls.Add(this.NoiCap);
            this.panelMenu.Controls.Add(this.SDTRieng);
            this.panelMenu.Controls.Add(this.label14);
            this.panelMenu.Controls.Add(this.SDTNha);
            this.panelMenu.Controls.Add(this.label13);
            this.panelMenu.Controls.Add(this.TinhTrangHonNhan);
            this.panelMenu.Controls.Add(this.NgayCap);
            this.panelMenu.Controls.Add(this.label10);
            this.panelMenu.Controls.Add(this.SoCCCD);
            this.panelMenu.Controls.Add(this.label9);
            this.panelMenu.Controls.Add(this.buttonLamMoi);
            this.panelMenu.Controls.Add(this.buttonTimKiem);
            this.panelMenu.Controls.Add(this.textBoxTimKiem);
            this.panelMenu.Controls.Add(this.labelTenBacLuong);
            this.panelMenu.Controls.Add(this.labelTenTrinhDo);
            this.panelMenu.Controls.Add(this.labelTenPhonBan);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.dateTimePickerNgaySinh);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.label7);
            this.panelMenu.Controls.Add(this.comboBoxMaBacLuong);
            this.panelMenu.Controls.Add(this.label6);
            this.panelMenu.Controls.Add(this.comboBoxMaTrinhDo);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.comboBoxMaPhongBan);
            this.panelMenu.Controls.Add(this.textBoxDiaChi);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.update);
            this.panelMenu.Controls.Add(this.delete);
            this.panelMenu.Controls.Add(this.add);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.textBoxTenNhanVien);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMaNhanVien);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 238);
            this.panelMenu.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(992, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 35);
            this.button2.TabIndex = 57;
            this.button2.Text = "Xuất phiếu lương";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(13, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 19);
            this.label15.TabIndex = 53;
            this.label15.Text = "Nơi cấp";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(13, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 52;
            this.label12.Text = "TT hôn nhân\r\n";
            // 
            // NoiCap
            // 
            this.NoiCap.Location = new System.Drawing.Point(100, 146);
            this.NoiCap.Name = "NoiCap";
            this.NoiCap.Size = new System.Drawing.Size(165, 20);
            this.NoiCap.TabIndex = 51;
            // 
            // SDTRieng
            // 
            this.SDTRieng.Location = new System.Drawing.Point(359, 147);
            this.SDTRieng.Name = "SDTRieng";
            this.SDTRieng.Size = new System.Drawing.Size(165, 20);
            this.SDTRieng.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(271, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 49;
            this.label14.Text = "SDT Riêng ";
            // 
            // SDTNha
            // 
            this.SDTNha.Location = new System.Drawing.Point(359, 171);
            this.SDTNha.Name = "SDTNha";
            this.SDTNha.Size = new System.Drawing.Size(165, 20);
            this.SDTNha.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(271, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "SDT Nhà";
            // 
            // TinhTrangHonNhan
            // 
            this.TinhTrangHonNhan.Location = new System.Drawing.Point(100, 171);
            this.TinhTrangHonNhan.Name = "TinhTrangHonNhan";
            this.TinhTrangHonNhan.Size = new System.Drawing.Size(165, 20);
            this.TinhTrangHonNhan.TabIndex = 46;
            // 
            // NgayCap
            // 
            this.NgayCap.Location = new System.Drawing.Point(324, 121);
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.Size = new System.Drawing.Size(200, 20);
            this.NgayCap.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(271, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "Ngày cấp";
            // 
            // SoCCCD
            // 
            this.SoCCCD.Location = new System.Drawing.Point(100, 120);
            this.SoCCCD.Name = "SoCCCD";
            this.SoCCCD.Size = new System.Drawing.Size(165, 20);
            this.SoCCCD.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "Số CCCD";
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.Orange;
            this.buttonLamMoi.FlatAppearance.BorderSize = 0;
            this.buttonLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLamMoi.Location = new System.Drawing.Point(1034, 122);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(134, 35);
            this.buttonLamMoi.TabIndex = 28;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(19, 204);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(505, 20);
            this.textBoxTimKiem.TabIndex = 26;
            // 
            // labelTenBacLuong
            // 
            this.labelTenBacLuong.Location = new System.Drawing.Point(793, 93);
            this.labelTenBacLuong.Name = "labelTenBacLuong";
            this.labelTenBacLuong.Size = new System.Drawing.Size(375, 19);
            this.labelTenBacLuong.TabIndex = 25;
            this.labelTenBacLuong.Text = "Tên bậc lương: ";
            // 
            // labelTenTrinhDo
            // 
            this.labelTenTrinhDo.Location = new System.Drawing.Point(793, 68);
            this.labelTenTrinhDo.Name = "labelTenTrinhDo";
            this.labelTenTrinhDo.Size = new System.Drawing.Size(375, 19);
            this.labelTenTrinhDo.TabIndex = 24;
            this.labelTenTrinhDo.Text = "Tên trình độ: ";
            // 
            // labelTenPhonBan
            // 
            this.labelTenPhonBan.Location = new System.Drawing.Point(793, 41);
            this.labelTenPhonBan.Name = "labelTenPhonBan";
            this.labelTenPhonBan.Size = new System.Drawing.Size(375, 19);
            this.labelTenPhonBan.TabIndex = 23;
            this.labelTenPhonBan.Text = "Tên phòng ban: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(274, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 50);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(324, 40);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgaySinh.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(271, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(540, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã bậc lương";
            // 
            // comboBoxMaBacLuong
            // 
            this.comboBoxMaBacLuong.FormattingEnabled = true;
            this.comboBoxMaBacLuong.Location = new System.Drawing.Point(622, 93);
            this.comboBoxMaBacLuong.Name = "comboBoxMaBacLuong";
            this.comboBoxMaBacLuong.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMaBacLuong.TabIndex = 18;
            this.comboBoxMaBacLuong.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaBacLuong_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(540, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã trình độ";
            // 
            // comboBoxMaTrinhDo
            // 
            this.comboBoxMaTrinhDo.FormattingEnabled = true;
            this.comboBoxMaTrinhDo.Location = new System.Drawing.Point(622, 68);
            this.comboBoxMaTrinhDo.Name = "comboBoxMaTrinhDo";
            this.comboBoxMaTrinhDo.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMaTrinhDo.TabIndex = 16;
            this.comboBoxMaTrinhDo.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaTrinhDo_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(540, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã phòng ban";
            // 
            // comboBoxMaPhongBan
            // 
            this.comboBoxMaPhongBan.FormattingEnabled = true;
            this.comboBoxMaPhongBan.Location = new System.Drawing.Point(622, 41);
            this.comboBoxMaPhongBan.Name = "comboBoxMaPhongBan";
            this.comboBoxMaPhongBan.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMaPhongBan.TabIndex = 14;
            this.comboBoxMaPhongBan.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaPhongBan_SelectionChangeCommitted);
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(100, 95);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(165, 20);
            this.textBoxDiaChi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên nhân viên";
            // 
            // textBoxTenNhanVien
            // 
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(100, 69);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(165, 20);
            this.textBoxTenNhanVien.TabIndex = 7;
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
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPhongBan
            // 
            this.panelPhongBan.Controls.Add(this.listPage);
            this.panelPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPhongBan.Location = new System.Drawing.Point(0, 244);
            this.panelPhongBan.Name = "panelPhongBan";
            this.panelPhongBan.Size = new System.Drawing.Size(1264, 413);
            this.panelPhongBan.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(1118, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 35);
            this.button3.TabIndex = 58;
            this.button3.Text = "Xuất danh sách ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageNv
            // 
            this.imageNv.Image = ((System.Drawing.Image)(resources.GetObject("imageNv.Image")));
            this.imageNv.Location = new System.Drawing.Point(622, 118);
            this.imageNv.Name = "imageNv";
            this.imageNv.Size = new System.Drawing.Size(108, 117);
            this.imageNv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNv.TabIndex = 55;
            this.imageNv.TabStop = false;
            this.imageNv.Click += new System.EventHandler(this.imageNv_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.gallery;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(736, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 39);
            this.button1.TabIndex = 54;
            this.button1.Text = "Thêm ảnh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addImage);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatAppearance.BorderSize = 0;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Image = global::QuanLyNhanSu.Properties.Resources.search;
            this.buttonTimKiem.Location = new System.Drawing.Point(530, 193);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(41, 39);
            this.buttonTimKiem.TabIndex = 27;
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Aqua;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Image = global::QuanLyNhanSu.Properties.Resources.rotation;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(892, 122);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(122, 34);
            this.update.TabIndex = 11;
            this.update.Text = "Cập nhật";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Image = global::QuanLyNhanSu.Properties.Resources.delete__1_;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(864, 195);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 35);
            this.delete.TabIndex = 10;
            this.delete.Text = "Xóa ";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Image = global::QuanLyNhanSu.Properties.Resources.add__1_;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(752, 121);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(122, 35);
            this.add.TabIndex = 9;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPhongBan);
            this.Name = "QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1264, 657);
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageNv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPage;
        private System.Windows.Forms.ColumnHeader MaNhanVien;
        private System.Windows.Forms.ColumnHeader TenNhanVien;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPhongBan;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMaPhongBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMaTrinhDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMaBacLuong;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelTenBacLuong;
        private System.Windows.Forms.Label labelTenTrinhDo;
        private System.Windows.Forms.Label labelTenPhonBan;
        private System.Windows.Forms.ColumnHeader ngaySinh;
        private System.Windows.Forms.ColumnHeader diachi;
        private System.Windows.Forms.ColumnHeader gioitinh;
        private System.Windows.Forms.ColumnHeader mapb;
        private System.Windows.Forms.ColumnHeader matd;
        private System.Windows.Forms.ColumnHeader mabl;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.TextBox NoiCap;
        private System.Windows.Forms.TextBox SDTRieng;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SDTNha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TinhTrangHonNhan;
        private System.Windows.Forms.DateTimePicker NgayCap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SoCCCD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox imageNv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
