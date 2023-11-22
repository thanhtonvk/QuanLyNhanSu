using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class ChucVuNhanVienDAO
    {
        DataHandle _handle;

        public ChucVuNhanVienDAO()
        {
            _handle = new DataHandle();
        }

        public List<ChucVuNhanVien> Get(string maNV)
        {
            List<ChucVuNhanVien> chucVuNhanViens = new List<ChucVuNhanVien>();
            string query = $"SELECT * FROM ChucVuNhanVien WHERE MaNV = '{maNV}'";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                chucVuNhanViens.Add(new ChucVuNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaCV = row["MaCV"].ToString(),
                    NgayBD = DateTime.Parse(row["NgayBD"].ToString()),
                    NgayKT = DateTime.Parse(row["NgayKT"].ToString())
                });
            }

            return chucVuNhanViens;
        }

        public bool Insert(ChucVuNhanVien chucVuNhanVien)
        {
            string query = $"INSERT INTO ChucVuNhanVien (MaNV, MaCV, NgayBD, NgayKT) VALUES ('{chucVuNhanVien.MaNV}', '{chucVuNhanVien.MaCV}', '{chucVuNhanVien.NgayBD}', '{chucVuNhanVien.NgayKT}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(ChucVuNhanVien chucVuNhanVien, string maNV, string maCV)
        {
            string query = $"UPDATE ChucVuNhanVien SET NgayBD = '{chucVuNhanVien.NgayBD}', NgayKT = '{chucVuNhanVien.NgayKT}' WHERE MaNV = '{maNV}' AND MaCV = '{maCV}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maNV, string maCV)
        {
            string query = $"DELETE FROM ChucVuNhanVien WHERE MaNV = '{maNV}' AND MaCV = '{maCV}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}
