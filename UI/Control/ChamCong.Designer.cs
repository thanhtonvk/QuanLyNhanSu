namespace QuanLyNhanSu.UI.Control
{
    partial class ChamCong
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
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayCC = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ghichu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioRa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioVao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayChamCong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPage = new System.Windows.Forms.ListView();
            this.panelPhongBan = new System.Windows.Forms.Panel();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textGioRa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGioVao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelPhongBan.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giờ vào";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(274, 90);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(346, 40);
            this.textBoxTimKiem.TabIndex = 26;
            // 
            // dateTimePickerNgayCC
            // 
            this.dateTimePickerNgayCC.Location = new System.Drawing.Point(396, 40);
            this.dateTimePickerNgayCC.Name = "dateTimePickerNgayCC";
            this.dateTimePickerNgayCC.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayCC.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(278, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày chấm công";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chấm công";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ghichu
            // 
            this.ghichu.Text = "Ghi chú";
            this.ghichu.Width = 129;
            // 
            // GioRa
            // 
            this.GioRa.Text = "Giờ ra";
            this.GioRa.Width = 111;
            // 
            // GioVao
            // 
            this.GioVao.Text = "Giờ vào";
            this.GioVao.Width = 150;
            // 
            // NgayChamCong
            // 
            this.NgayChamCong.Text = "Ngày chấm công";
            this.NgayChamCong.Width = 111;
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã nhân viên";
            this.MaNV.Width = 126;
            // 
            // MaCC
            // 
            this.MaCC.Text = "Mã chấm công";
            this.MaCC.Width = 82;
            // 
            // listPage
            // 
            this.listPage.AccessibleName = "";
            this.listPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaCC,
            this.MaNV,
            this.NgayChamCong,
            this.GioVao,
            this.GioRa,
            this.ghichu});
            this.listPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPage.HideSelection = false;
            this.listPage.Location = new System.Drawing.Point(0, 0);
            this.listPage.Name = "listPage";
            this.listPage.Size = new System.Drawing.Size(1264, 527);
            this.listPage.TabIndex = 0;
            this.listPage.Tag = "";
            this.listPage.UseCompatibleStateImageBehavior = false;
            this.listPage.View = System.Windows.Forms.View.Details;
            this.listPage.SelectedIndexChanged += new System.EventHandler(this.listPage_SelectedIndexChanged);
            // 
            // panelPhongBan
            // 
            this.panelPhongBan.Controls.Add(this.listPage);
            this.panelPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPhongBan.Location = new System.Drawing.Point(0, 130);
            this.panelPhongBan.Name = "panelPhongBan";
            this.panelPhongBan.Size = new System.Drawing.Size(1264, 527);
            this.panelPhongBan.TabIndex = 6;
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(100, 40);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(165, 20);
            this.textBoxMaNhanVien.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.textGhiChu);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.textGioRa);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.textGioVao);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.textBoxTimKiem);
            this.panelMenu.Controls.Add(this.dateTimePickerNgayCC);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMaNhanVien);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 132);
            this.panelMenu.TabIndex = 7;
            // 
            // textGhiChu
            // 
            this.textGhiChu.Location = new System.Drawing.Point(672, 37);
            this.textGhiChu.Name = "textGhiChu";
            this.textGhiChu.Size = new System.Drawing.Size(165, 20);
            this.textGhiChu.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(618, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ghi chú ";
            // 
            // textGioRa
            // 
            this.textGioRa.Location = new System.Drawing.Point(396, 68);
            this.textGioRa.Name = "textGioRa";
            this.textGioRa.Size = new System.Drawing.Size(200, 20);
            this.textGioRa.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(278, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giờ ra";
            // 
            // textGioVao
            // 
            this.textGioVao.Location = new System.Drawing.Point(100, 68);
            this.textGioVao.Name = "textGioVao";
            this.textGioVao.Size = new System.Drawing.Size(165, 20);
            this.textGioVao.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.rotation;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(100, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 44;
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
            this.button2.Location = new System.Drawing.Point(201, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 43);
            this.button2.TabIndex = 43;
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
            this.button3.Location = new System.Drawing.Point(-1, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 41);
            this.button3.TabIndex = 42;
            this.button3.Text = "Thêm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::QuanLyNhanSu.Properties.Resources.circular_arrow;
            this.button4.Location = new System.Drawing.Point(675, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 38);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Image = global::QuanLyNhanSu.Properties.Resources.search;
            this.button5.Location = new System.Drawing.Point(626, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 38);
            this.button5.TabIndex = 40;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPhongBan);
            this.Controls.Add(this.panelMenu);
            this.Name = "ChamCong";
            this.Size = new System.Drawing.Size(1264, 657);
            this.Load += new System.EventHandler(this.ChamCong_Load);
            this.panelPhongBan.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ghichu;
        private System.Windows.Forms.ColumnHeader GioRa;
        private System.Windows.Forms.ColumnHeader GioVao;
        private System.Windows.Forms.ColumnHeader NgayChamCong;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader MaCC;
        private System.Windows.Forms.ListView listPage;
        private System.Windows.Forms.Panel panelPhongBan;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TextBox textGhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textGioRa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGioVao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
