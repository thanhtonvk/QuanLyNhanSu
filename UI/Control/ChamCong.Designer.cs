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
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayCC = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
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
            this.textGioVao = new System.Windows.Forms.TextBox();
            this.textGioRa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(718, 101);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(75, 23);
            this.buttonLamMoi.TabIndex = 28;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(637, 101);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(75, 23);
            this.buttonTimKiem.TabIndex = 27;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(274, 103);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(346, 20);
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
            // update
            // 
            this.update.Location = new System.Drawing.Point(94, 100);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 11;
            this.update.Text = "Cập nhật";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(184, 100);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 10;
            this.delete.Text = "Xóa ";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 100);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 9;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.panelMenu.Controls.Add(this.textGhiChu);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.textGioRa);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.textGioVao);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.buttonLamMoi);
            this.panelMenu.Controls.Add(this.buttonTimKiem);
            this.panelMenu.Controls.Add(this.textBoxTimKiem);
            this.panelMenu.Controls.Add(this.dateTimePickerNgayCC);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.update);
            this.panelMenu.Controls.Add(this.delete);
            this.panelMenu.Controls.Add(this.add);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMaNhanVien);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 132);
            this.panelMenu.TabIndex = 7;
            // 
            // textGioVao
            // 
            this.textGioVao.Location = new System.Drawing.Point(100, 68);
            this.textGioVao.Name = "textGioVao";
            this.textGioVao.Size = new System.Drawing.Size(165, 20);
            this.textGioVao.TabIndex = 30;
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
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
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
    }
}
