using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace QuanLyNhanSu.DAO
{
    internal class NgoaiNguNhanVienDAO
    {
        DataHandle _handle;

        public NgoaiNguNhanVienDAO()
        {
            _handle = new DataHandle();
        }
        public List<NgoaiNguNhanVien> GetAll()
        {
            List<NgoaiNguNhanVien> ngoaiNguNhanViens = new List<NgoaiNguNhanVien>();
            string query =
                $"SELECT NgoaiNguNhanVien.MaNV, NgoaiNguNhanVien.MaNN, NgoaiNguNhanVien.NgayCap, NgoaiNgu.TenNN FROM NgoaiNguNhanVien INNER JOIN NgoaiNgu ON NgoaiNguNhanVien.MaNN = NgoaiNgu.MaNN";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                ngoaiNguNhanViens.Add(new NgoaiNguNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaNN = row["MaNN"].ToString(),
                    NgayCap =DateTime.Parse(row["NgayCap"].ToString()),
                    TenNN = row["TenNN"].ToString()
                });
            }

            return ngoaiNguNhanViens;
        }
        public List<NgoaiNguNhanVien> Get(string maNV)
        {
            List<NgoaiNguNhanVien> ngoaiNguNhanViens = new List<NgoaiNguNhanVien>();
            string query =
                $"SELECT NgoaiNguNhanVien.MaNV, NgoaiNguNhanVien.MaNN, NgoaiNguNhanVien.NgayCap, NgoaiNgu.TenNN FROM NgoaiNguNhanVien INNER JOIN NgoaiNgu ON NgoaiNguNhanVien.MaNN = NgoaiNgu.MaNN WHERE NgoaiNguNhanVien.MaNV = '{maNV}'";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                ngoaiNguNhanViens.Add(new NgoaiNguNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaNN = row["MaNN"].ToString(),
                    NgayCap = DateTime.Parse(row["NgayCap"].ToString()),
                    TenNN = row["TenNN"].ToString()
                });
            }

            return ngoaiNguNhanViens;
        }

        public bool Insert(NgoaiNguNhanVien ngoaiNguNhanVien)
        {
            string query =
                $"INSERT INTO NgoaiNguNhanVien (MaNV, MaNN, NgayCap) VALUES ('{ngoaiNguNhanVien.MaNV}', '{ngoaiNguNhanVien.MaNN}', '{ngoaiNguNhanVien.NgayCap:yyyy-MM-dd HH:mm:ss}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(NgoaiNguNhanVien ngoaiNguNhanVien)
        {
            string query =
                $"UPDATE NgoaiNguNhanVien SET NgayCap = '{ngoaiNguNhanVien.NgayCap:yyyy-MM-dd HH:mm:ss}' WHERE MaNV = '{ngoaiNguNhanVien.MaNV}' AND MaNN = '{ngoaiNguNhanVien.MaNN}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maNV, string maNN)
        {
            string query = $"DELETE FROM NgoaiNguNhanVien WHERE MaNV = '{maNV}' AND MaNN = '{maNN}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}