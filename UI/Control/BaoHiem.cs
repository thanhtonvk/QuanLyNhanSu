﻿using ArrayToExcel;
using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.UI.Control
{
    public partial class BaoHiem : UserControl
    {
        private BaoHiemDAO _dao = new BaoHiemDAO();
        private List<Model.BaoHiem> list = new List<Model.BaoHiem>();
        public BaoHiem()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiểm");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên bảo hiểm");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_dao.Insert(new Model.BaoHiem()
                {
                    MaBH = textBoxMa.Text,
                    TenBH = textBoxTen.Text,
                }))
                {
                    OnLoadListView();
                    textBoxMa.Text = "";
                    textBoxTen.Text = "";
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiểm");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên bảo hiểm");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_dao.Update(new Model.BaoHiem()
                {
                    MaBH = textBoxMa.Text,
                    TenBH = textBoxTen.Text,
                }))
                {
                    OnLoadListView();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiểm");
            }


            if (!String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                if (_dao.Delete(textBoxMa.Text))
                {
                    OnLoadListView();
                    textBoxMa.Text = "";
                    textBoxTen.Text = "";
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void listPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPage.SelectedItems.Count > 0)
            {
                textBoxMa.Text = listPage.SelectedItems[0].SubItems[0].Text;
                textBoxTen.Text = listPage.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void BaoHiem_Load(object sender, EventArgs e)
        {
            listPage.Columns[0].Width = (int)(listPage.Width * 0.25);
            listPage.Columns[1].Width = (int)(listPage.Width * 0.25);
            listPage.View = View.Details;
            listPage.GridLines = true;
            listPage.FullRowSelect = true;
            OnLoadListView();
        }
        //Load data vào list view
        private void OnLoadListView()
        {
            listPage.Items.Clear();
            list = _dao.GetAll();
            foreach (var item in list)
            {
                ListViewItem viewItem = listPage.Items.Add(item.MaBH);
                viewItem.SubItems.Add(item.TenBH);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiểm");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên bảo hiểm");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_dao.Insert(new Model.BaoHiem()
                {
                    MaBH = textBoxMa.Text,
                    TenBH = textBoxTen.Text,
                }))
                {
                    OnLoadListView();
                    textBoxMa.Text = "";
                    textBoxTen.Text = "";
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiểm");
            }

            if (String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                MessageBox.Show("Không được bỏ trống tên bảo hiểm");
            }

            if (!String.IsNullOrWhiteSpace(textBoxMa.Text) && !String.IsNullOrWhiteSpace(textBoxTen.Text))
            {
                if (_dao.Update(new Model.BaoHiem()
                {
                    MaBH = textBoxMa.Text,
                    TenBH = textBoxTen.Text,
                }))
                {
                    OnLoadListView();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                MessageBox.Show("Không được bỏ trống mã bảo hiểm");
            }


            if (!String.IsNullOrWhiteSpace(textBoxMa.Text))
            {
                if (_dao.Delete(textBoxMa.Text))
                {
                    OnLoadListView();
                    textBoxMa.Text = "";
                    textBoxTen.Text = "";
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var excel = _dao.GetAll().ToExcel();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("Excel File|*.xlsx");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, excel);
            }
        }
    }
}
