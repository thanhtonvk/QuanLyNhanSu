using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class NhanVienDAO
    {
        DataHandle _handle;

        public NhanVienDAO()
        {
            _handle = new DataHandle();
        }

        public List<NhanVien> Get(string keyword)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query =
                $"select NhanVien.MaNV, TenNV, NgaySinh, DiaChi, GioiTinh, TenPB, TenTD, TenBL, NhanVien.MaPB, NhanVien.MaTD, NhanVien.MaBL " +
                $"from NhanVien, PhongBan, TrinhDo, BacLuong " +
                $"where NhanVien.MaPB = PhongBan.MaPB   and NhanVien.MaTD = TrinhDo.MaTD   and NhanVien.MaBL = BacLuong.MaBL   and (NhanVien.MaNV like '%{keyword}%' or TenNV like '%{keyword}%' or NgaySinh like '%{keyword}%' or DiaChi like '%{keyword}%' or TenPB like '%{keyword}%' or TenTD like '%{keyword}%' or TenTD like '%{keyword}%')";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                nhanViens.Add(new NhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    TenNV = row["TenNV"].ToString(),
                    NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()),
                    DiaChi = row["DiaChi"].ToString(),
                    GioiTinh = bool.Parse(row["GioiTinh"].ToString()),
                    MaPB = row["MaPB"].ToString(),
                    MaTD = row["MaTD"].ToString(),
                    MaBL = row["MaBL"].ToString(),
                    TenTd = row["TenTD"].ToString(),
                    TenPB = row["TenPB"].ToString(),
                    TenBL = row["TenBL"].ToString()
                });
            }

            return nhanViens;
        }

        public bool Insert(NhanVien nhanVien)
        {
            string query = $"insert into NhanVien(MaNV, TenNV, NgaySinh, DiaChi, GioiTinh, MaPB, MaTD, MaBL) " +
                           $"values ('{nhanVien.MaNV}',N'{nhanVien.TenNV}','{nhanVien.NgaySinh}'),N'{nhanVien.DiaChi}',{nhanVien.GioiTinh},'{nhanVien.MaPB}','{nhanVien.MaTD}','{nhanVien.MaBL}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(NhanVien nhanVien, string maNv)
        {
            string query =
                $"UPDATE NhanVien SET TenNV = N'{nhanVien.TenNV}',NgaySinh='{nhanVien.NgaySinh}',DiaChi=N'{nhanVien.DiaChi}',GioiTinh={nhanVien.GioiTinh},MaPB='{nhanVien.MaPB}',MaBL='{nhanVien.MaBL}',MaTD='{nhanVien.MaTD}' where MaNV = '{maNv}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maNv)
        {
            string query = $"delete from NhanVien where MaNV = '{maNv}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}