using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class BacLuongDAO
    {
        DataHandle _handle;

        public BacLuongDAO()
        {
            _handle = new DataHandle();
        }

        public List<BacLuong> GetAll()
        {
            List<BacLuong> bacLuongs = new List<BacLuong>();
            string query = "SELECT * FROM BacLuong";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                bacLuongs.Add(new BacLuong()
                {
                    MaBL = row["MaBL"].ToString(),
                    TenBL = row["TenBL"].ToString(),
                    HeSBL = float.Parse(row["HeSBL"].ToString())
                });
            }

            return bacLuongs;
        }

        public bool Insert(BacLuong bacLuong)
        {
            string query = $"INSERT INTO BacLuong (MaBL, TenBL, HeSBL) " +
                           $"VALUES ('{bacLuong.MaBL}', N'{bacLuong.TenBL}', {bacLuong.HeSBL})";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(BacLuong bacLuong, string maBL)
        {
            string query = $"UPDATE BacLuong " +
                           $"SET TenBL = N'{bacLuong.TenBL}', HeSBL = {bacLuong.HeSBL} " +
                           $"WHERE MaBL = '{maBL}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maBL)
        {
            string query = $"DELETE FROM BacLuong " +
                           $"WHERE MaBL = '{maBL}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}