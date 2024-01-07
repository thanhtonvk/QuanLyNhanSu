using QuanLyNhanSu.Model;
using QuanLyNhanSu.UI.Control;
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
        public NhanVien GetNV(string manv)
        {
            NhanVien nhanVien = new NhanVien();
            string query = $"SELECT * FROM NhanVien WHERE MaNV = N'{manv}'";
            DataTable dataTable = _handle.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                nhanVien = new NhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    TenNV = row["TenNV"].ToString(),
                    HinhAnh = row["HinhAnh"].ToString(),
                    NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()),
                    DiaChi = row["DiaChi"].ToString(),
                    SoCCCD = row["SoCCCD"].ToString(),
                    NgayCap = DateTime.Parse(row["NgayCap"].ToString()),
                    NoiCap = row["NoiCap"].ToString(),
                    SDTRieng = row["SDTRieng"].ToString(),
                    SDTNha = row["SDTNha"].ToString(),
                    TinhTrangHonNhan = row["TinhTrangHonNhan"].ToString(),
                    GioiTinh = int.Parse(row["GioiTinh"].ToString()),
                    MaPB = row["MaPB"].ToString(),
                    MaTD = row["MaTD"].ToString(),
                    MaBL = row["MaBL"].ToString(),
                };
            }

            return nhanVien;
        }
        public List<NhanVien> GetAll()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query = "SELECT * FROM NhanVien";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                nhanViens.Add(new NhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    TenNV = row["TenNV"].ToString(),
                    HinhAnh = row["HinhAnh"].ToString(),
                    NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()),
                    DiaChi = row["DiaChi"].ToString(),
                    SoCCCD = row["SoCCCD"].ToString(),
                    NgayCap = DateTime.Parse(row["NgayCap"].ToString()),
                    NoiCap = row["NoiCap"].ToString(),
                    SDTRieng = row["SDTRieng"].ToString(),
                    SDTNha = row["SDTNha"].ToString(),
                    TinhTrangHonNhan = row["TinhTrangHonNhan"].ToString(),
                    GioiTinh = int.Parse(row["GioiTinh"].ToString()),
                    MaPB = row["MaPB"].ToString(),
                    MaTD = row["MaTD"].ToString(),
                    MaBL = row["MaBL"].ToString(),
                });
            }

            return nhanViens;
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
                    HinhAnh = row["HinhAnh"].ToString(),
                    NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()),
                    DiaChi = row["DiaChi"].ToString(),
                    SoCCCD = row["SoCCCD"].ToString(),
                    NgayCap = DateTime.Parse(row["NgayCap"].ToString()),
                    NoiCap = row["NoiCap"].ToString(),
                    SDTRieng = row["SDTRieng"].ToString(),
                    SDTNha = row["SDTNha"].ToString(),
                    TinhTrangHonNhan = row["TinhTrangHonNhan"].ToString(),
                    GioiTinh = int.Parse(row["GioiTinh"].ToString()),
                    MaPB = row["MaPB"].ToString(),
                    MaTD = row["MaTD"].ToString(),
                    MaBL = row["MaBL"].ToString(),
                });
            }

            return nhanViens;
        }

        public bool Insert(NhanVien nhanVien)
        {
            string query = $"insert into NhanVien(MaNV, TenNV,HinhAnh,SoCCCD,NgayCap,NoiCap,SDTRieng,SDTNha,TinhTrangHonNhan , NgaySinh, DiaChi, GioiTinh, MaPB, MaTD, MaBL) " +
                           $"values ('{nhanVien.MaNV}',N'{nhanVien.TenNV}',N'{nhanVien.HinhAnh}',N'{nhanVien.SoCCCD}',N'{nhanVien.NgayCap}',N'{nhanVien.NoiCap}',N'{nhanVien.SDTRieng}',N'{nhanVien.SDTNha}',N'{nhanVien.TinhTrangHonNhan}'," +
                           $"'{nhanVien.NgaySinh}',N'{nhanVien.DiaChi}'," +
                           $"{nhanVien.GioiTinh},'{nhanVien.MaPB}','{nhanVien.MaTD}','{nhanVien.MaBL}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(NhanVien nhanVien)
        {
            string queryCheck = $"select * from [NhanVien] where MaNV = N'{nhanVien.MaNV}'";
            DataTable dataTable = _handle.ExecuteQuery(queryCheck);
            if (dataTable.Rows.Count > 0)
            {
                string query =
                $"UPDATE NhanVien SET TenNV = N'{nhanVien.TenNV}', HinhAnh  = N'{nhanVien.HinhAnh}', SoCCCD  = N'{nhanVien.SoCCCD}', NgayCap  = N'{nhanVien.NgayCap}'," +
                $" NoiCap  = N'{nhanVien.NoiCap}', SDTRieng  = N'{nhanVien.SDTRieng}', SDTNha  = N'{nhanVien.SDTNha}', TinhTrangHonNhan  = N'{nhanVien.TinhTrangHonNhan}'," +
                $"NgaySinh='{nhanVien.NgaySinh}',DiaChi=N'{nhanVien.DiaChi}',GioiTinh={nhanVien.GioiTinh},MaPB='{nhanVien.MaPB}',MaBL='{nhanVien.MaBL}',MaTD='{nhanVien.MaTD}' where MaNV = '{nhanVien.MaNV}'";
                bool result = _handle.ExecuteNonQuery(query);
                return result;
            }
            return false;

        }

        public bool Delete(string maNv)
        {
            string query = $"delete from NhanVien where MaNV = '{maNv}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}