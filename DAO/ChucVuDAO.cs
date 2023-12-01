using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class ChucVuDAO
    {
        DataHandle _handle;

        public ChucVuDAO()
        {
            _handle = new DataHandle();
        }

        public List<ChucVu> Get()
        {
            List<ChucVu> chucVus = new List<ChucVu>();
            string query = "SELECT * FROM ChucVu";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                chucVus.Add(new ChucVu()
                {
                    MaCV = row["MaCV"].ToString(),
                    TenCV = row["TenCV"].ToString()
                });
            }

            return chucVus;
        }

        public bool Insert(ChucVu chucVu)
        {
            string query = $"INSERT INTO ChucVu (MaCV, TenCV) VALUES ('{chucVu.MaCV}', N'{chucVu.TenCV}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(ChucVu chucVu)
        {
            string queryCheck = $"select * from [ChucVu] where MaCV = N'{chucVu.MaCV}'";
            DataTable dataTable = _handle.ExecuteQuery(queryCheck);
            if (dataTable.Rows.Count > 0)
            {
                string query = $"UPDATE ChucVu SET TenCV = N'{chucVu.TenCV}' WHERE MaCV = '{chucVu.MaCV}'";
                bool result = _handle.ExecuteNonQuery(query);
                return result;
            }
            return false;
        }

        public bool Delete(string maCV)
        {
            string query = $"DELETE FROM ChucVu WHERE MaCV = '{maCV}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}