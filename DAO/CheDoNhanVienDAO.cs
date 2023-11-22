using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class CheDoNhanVienDAO
    {
        DataHandle _handle;

        public CheDoNhanVienDAO()
        {
            _handle = new DataHandle();
        }

        public List<CheDoNhanVien> GetAll()
        {
            List<CheDoNhanVien> cheDoNhanViens = new List<CheDoNhanVien>();
            string query =
                "SELECT CheDoNhanVien.MaNV,TenNV,TenCD, CheDo.MaCD, NgayBD, NgayKT FROM CheDoNhanVien,CheDo,NhanVien where CheDo.MaCD = CheDoNhanVien.MaCD and NhanVien.MaNV = CheDoNhanVien.MaNV";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                cheDoNhanViens.Add(new CheDoNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaCD = row["MaCD"].ToString(),
                    NgayBD = DateTime.Parse(row["NgayBD"].ToString()),
                    NgayKT = DateTime.Parse(row["NgayKT"].ToString()),
                    TenCD = row["TenCD"].ToString(),
                    TenNV = row["TenNV"].ToString()
                });
            }

            return cheDoNhanViens;
        }

        public bool Insert(CheDoNhanVien cheDoNhanVien)
        {
            string query = $"INSERT INTO CheDoNhanVien (MaNV, MaCD, NgayBD, NgayKT) " +
                           $"VALUES ('{cheDoNhanVien.MaNV}', '{cheDoNhanVien.MaCD}', " +
                           $"'{cheDoNhanVien.NgayBD}', '{cheDoNhanVien.NgayKT}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(CheDoNhanVien cheDoNhanVien, string maNV, string maCD)
        {
            string query = $"UPDATE CheDoNhanVien " +
                           $"SET NgayBD = '{cheDoNhanVien.NgayBD}', NgayKT = '{cheDoNhanVien.NgayKT}' " +
                           $"WHERE MaNV = '{maNV}' AND MaCD = '{maCD}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maNV, string maCD)
        {
            string query = $"DELETE FROM CheDoNhanVien " +
                           $"WHERE MaNV = '{maNV}' AND MaCD = '{maCD}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}