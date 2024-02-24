namespace QuanLyNhanSu.UI.Control
{
    partial class PhongBan
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenPhongBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listPage = new System.Windows.Forms.ListView();
            this.MaPhongBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenPhongBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelPhongBan = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.textBoxTenPhongBan);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMaPhongBan);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1000, 100);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.rotation;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(403, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cập nhật";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Image = global::QuanLyNhanSu.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(504, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 34);
            this.button2.TabIndex = 41;
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
            this.button3.Location = new System.Drawing.Point(302, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 40;
            this.button3.Text = "Thêm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên phòng ban";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxTenPhongBan
            // 
            this.textBoxTenPhongBan.Location = new System.Drawing.Point(100, 69);
            this.textBoxTenPhongBan.Name = "textBoxTenPhongBan";
            this.textBoxTenPhongBan.Size = new System.Drawing.Size(165, 20);
            this.textBoxTenPhongBan.TabIndex = 7;
            this.textBoxTenPhongBan.TextChanged += new System.EventHandler(this.textBoxTenPhongBan_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã phong ban";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMaPhongBan
            // 
            this.textBoxMaPhongBan.Location = new System.Drawing.Point(100, 40);
            this.textBoxMaPhongBan.Name = "textBoxMaPhongBan";
            this.textBoxMaPhongBan.Size = new System.Drawing.Size(165, 20);
            this.textBoxMaPhongBan.TabIndex = 2;
            this.textBoxMaPhongBan.TextChanged += new System.EventHandler(this.textBoxMaPhongBan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng ban";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listPage
            // 
            this.listPage.AccessibleName = "";
            this.listPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhongBan,
            this.TenPhongBan});
            this.listPage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPage.HideSelection = false;
            this.listPage.Location = new System.Drawing.Point(3, 3);
            this.listPage.Name = "listPage";
            this.listPage.Size = new System.Drawing.Size(994, 388);
            this.listPage.TabIndex = 0;
            this.listPage.Tag = "";
            this.listPage.UseCompatibleStateImageBehavior = false;
            this.listPage.View = System.Windows.Forms.View.Details;
            this.listPage.SelectedIndexChanged += new System.EventHandler(this.listPage_SelectedIndexChanged);
            // 
            // MaPhongBan
            // 
            this.MaPhongBan.Text = "Mã phong ban";
            this.MaPhongBan.Width = 291;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.Text = "Tên phòng ban";
            this.TenPhongBan.Width = 533;
            // 
            // panelPhongBan
            // 
            this.panelPhongBan.Controls.Add(this.listPage);
            this.panelPhongBan.Location = new System.Drawing.Point(0, 106);
            this.panelPhongBan.Name = "panelPhongBan";
            this.panelPhongBan.Size = new System.Drawing.Size(1077, 423);
            this.panelPhongBan.TabIndex = 0;
            this.panelPhongBan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPhongBan_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(590, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 34);
            this.button4.TabIndex = 61;
            this.button4.Text = "Xuất danh sách ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPhongBan);
            this.Name = "PhongBan";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.PhongBan_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listPage;
        private System.Windows.Forms.ColumnHeader MaPhongBan;
        private System.Windows.Forms.ColumnHeader TenPhongBan;
        private System.Windows.Forms.Panel panelPhongBan;
        private System.Windows.Forms.Button button4;
    }
}
