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
        public List<ChucVuNhanVien> GetAll()
        {
            List<ChucVuNhanVien> chucVuNhanViens = new List<ChucVuNhanVien>();
            string query =$"SELECT NhanVien.MaNV,ChucVu.MaCV,NgayBD,NgayKT,TenNV,TenCV FROM ChucVuNhanVien,ChucVu,NhanVien WHERE ChucVuNhanVien.MaCV = ChucVu.MaCV and ChucVuNhanVien.MaNV = NhanVien.MaNV";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                chucVuNhanViens.Add(new ChucVuNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaCV = row["MaCV"].ToString(),
                    NgayBD = DateTime.Parse(row["NgayBD"].ToString()),
                    NgayKT = DateTime.Parse(row["NgayKT"].ToString()),
                    TenCV = row["TenCV"].ToString(),
                    TenNV = row["TenNV"].ToString()
                });
            }

            return chucVuNhanViens;
        }
        public List<ChucVuNhanVien> Get(string maNV)
        {
            List<ChucVuNhanVien> chucVuNhanViens = new List<ChucVuNhanVien>();
            string query =
                $"SELECT NhanVien.MaNV,ChucVu.MaCV,NgayBD,NgayKT,TenNV,TenCV FROM ChucVuNhanVien,ChucVu,NhanVien WHERE ChucVuNhanVien.MaCV = ChucVu.MaCV and ChucVuNhanVien.MaNV = NhanVien.MaNV and  ChucVuNhanVien.MaNV = '{maNV}'";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                chucVuNhanViens.Add(new ChucVuNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaCV = row["MaCV"].ToString(),
                    NgayBD = DateTime.Parse(row["NgayBD"].ToString()),
                    NgayKT = DateTime.Parse(row["NgayKT"].ToString()),
                    TenCV = row["TenCV"].ToString(),
                    TenNV = row["TenNV"].ToString()
                });
            }

            return chucVuNhanViens;
        }

        public bool Insert(ChucVuNhanVien chucVuNhanVien)
        {
            string query =
                $"INSERT INTO ChucVuNhanVien (MaNV, MaCV, NgayBD, NgayKT) VALUES ('{chucVuNhanVien.MaNV}', '{chucVuNhanVien.MaCV}', N'{chucVuNhanVien.NgayBD}', N'{chucVuNhanVien.NgayKT}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(ChucVuNhanVien chucVuNhanVien)
        {

            string queryCheck = $"select * from [ChucVuNhanVien] where MaNV = N'{chucVuNhanVien.MaNV}'";
            DataTable dataTable = _handle.ExecuteQuery(queryCheck);
            if (dataTable.Rows.Count > 0)
            {
                string query =
               $"UPDATE ChucVuNhanVien SET NgayBD = '{chucVuNhanVien.NgayBD}', NgayKT = '{chucVuNhanVien.NgayKT}',MaCV = '{chucVuNhanVien.MaCV}' WHERE MaNV = '{chucVuNhanVien.MaNV}'";
                bool result = _handle.ExecuteNonQuery(query);
                return result;
            }
            return false;

        }

        public bool Delete(string maNV, string maCV)
        {
            string query = $"DELETE FROM ChucVuNhanVien WHERE MaNV = '{maNV}' AND MaCV = '{maCV}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}