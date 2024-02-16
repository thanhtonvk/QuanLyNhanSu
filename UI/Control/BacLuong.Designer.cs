namespace QuanLyNhanSu.UI.Control
{
    partial class BacLuong
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHeSoBacLuong = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPhongBan = new System.Windows.Forms.Panel();
            this.listPage = new System.Windows.Forms.ListView();
            this.Ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hesoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMenu.SuspendLayout();
            this.panelPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.textBoxHeSoBacLuong);
            this.panelMenu.Controls.Add(this.update);
            this.panelMenu.Controls.Add(this.delete);
            this.panelMenu.Controls.Add(this.add);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.textBoxTen);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textBoxMa);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 100);
            this.panelMenu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(271, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hệ số bậc lương";
            // 
            // textBoxHeSoBacLuong
            // 
            this.textBoxHeSoBacLuong.Location = new System.Drawing.Point(387, 38);
            this.textBoxHeSoBacLuong.Name = "textBoxHeSoBacLuong";
            this.textBoxHeSoBacLuong.Size = new System.Drawing.Size(165, 20);
            this.textBoxHeSoBacLuong.TabIndex = 12;
            this.textBoxHeSoBacLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.update.Image = global::QuanLyNhanSu.Properties.Resources.rotation;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(488, 66);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 35);
            this.update.TabIndex = 11;
            this.update.Text = "Cập nhật";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.Image = global::QuanLyNhanSu.Properties.Resources.delete;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(589, 66);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(80, 37);
            this.delete.TabIndex = 10;
            this.delete.Text = "Xóa ";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add.Image = global::QuanLyNhanSu.Properties.Resources.add__1_;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(387, 66);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 34);
            this.add.TabIndex = 9;
            this.add.Text = "Thêm";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên bậc lương";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(100, 69);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(165, 20);
            this.textBoxTen.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã bậc lương";
            // 
            // textBoxMa
            // 
            this.textBoxMa.Location = new System.Drawing.Point(100, 40);
            this.textBoxMa.Name = "textBoxMa";
            this.textBoxMa.Size = new System.Drawing.Size(165, 20);
            this.textBoxMa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bậc lương";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPhongBan
            // 
            this.panelPhongBan.Controls.Add(this.listPage);
            this.panelPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPhongBan.Location = new System.Drawing.Point(0, 106);
            this.panelPhongBan.Name = "panelPhongBan";
            this.panelPhongBan.Size = new System.Drawing.Size(1264, 551);
            this.panelPhongBan.TabIndex = 6;
            // 
            // listPage
            // 
            this.listPage.AccessibleName = "";
            this.listPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ma,
            this.Ten,
            this.hesoluong});
            this.listPage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPage.HideSelection = false;
            this.listPage.Location = new System.Drawing.Point(3, 3);
            this.listPage.Name = "listPage";
            this.listPage.Size = new System.Drawing.Size(1258, 545);
            this.listPage.TabIndex = 0;
            this.listPage.Tag = "";
            this.listPage.UseCompatibleStateImageBehavior = false;
            this.listPage.View = System.Windows.Forms.View.Details;
            this.listPage.SelectedIndexChanged += new System.EventHandler(this.listPage_SelectedIndexChanged);
            // 
            // Ma
            // 
            this.Ma.Text = "Mã bậc lương";
            this.Ma.Width = 291;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên bậc lương";
            this.Ten.Width = 533;
            // 
            // hesoluong
            // 
            this.hesoluong.Text = "Hệ số lương";
            // 
            // BacLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPhongBan);
            this.Name = "BacLuong";
            this.Size = new System.Drawing.Size(1264, 657);
            this.Load += new System.EventHandler(this.BacLuong_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHeSoBacLuong;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPhongBan;
        private System.Windows.Forms.ListView listPage;
        private System.Windows.Forms.ColumnHeader Ma;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader hesoluong;
    }
}
