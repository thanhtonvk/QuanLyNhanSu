using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class BaoHiemNhanVienDAO
    {
        DataHandle _handle;

        public BaoHiemNhanVienDAO()
        {
            _handle = new DataHandle();
        }
        public List<BaoHiemNhanVien> Get(string maNV)
        {
            List<BaoHiemNhanVien> baoHiemNhanViens = new List<BaoHiemNhanVien>();
            string query =
                $"SELECT NhanVien.MaNV,NhanVien.TenNV,BaoHiemNhanVien.MABH, NGAYBD, NGAYKT, NOICAP, GHICHU,TENBH FROM BaoHiemNhanVien,BaoHiem,NhanVien where BaoHiem.MaBH = BaoHiemNhanVien.MaBH and BaoHiemNhanVien.MaNV = NhanVien.MaNV and  BaoHiemNhanVien.MaNV = '{maNV}'";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                baoHiemNhanViens.Add(new BaoHiemNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaBH = row["MaBH"].ToString(),
                    NgayBD = DateTime.Parse(row["NgayBD"].ToString()),
                    NgayKT = DateTime.Parse(row["NgayKT"].ToString()),
                    NoiCap = row["NoiCap"].ToString(),
                    GhiChu = row["GhiChu"].ToString(),
                    TenBH = row["TenBH"].ToString(),
                    TenNV = row["TenNV"].ToString()
                });
            }

            return baoHiemNhanViens;
        }
        public List<BaoHiemNhanVien> GetAll()
        {
            List<BaoHiemNhanVien> baoHiemNhanViens = new List<BaoHiemNhanVien>();
            string query =
                "SELECT NhanVien.MaNV,NhanVien.TenNV,BaoHiemNhanVien.MABH, NGAYBD, NGAYKT,  NhanVien.NOICAP, GHICHU,TENBH FROM BaoHiemNhanVien,BaoHiem,NhanVien where BaoHiem.MaBH = BaoHiemNhanVien.MaBH and BaoHiemNhanVien.MaNV = NhanVien.MaNV";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                baoHiemNhanViens.Add(new BaoHiemNhanVien()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaBH = row["MaBH"].ToString(),
                    NgayBD = DateTime.Parse(row["NgayBD"].ToString()),
                    NgayKT = DateTime.Parse(row["NgayKT"].ToString()),
                    NoiCap = row["NoiCap"].ToString(),
                    GhiChu = row["GhiChu"].ToString(),
                    TenBH = row["TenBH"].ToString(),
                    TenNV = row["TenNV"].ToString()
                });
            }

            return baoHiemNhanViens;
        }

        public bool Insert(BaoHiemNhanVien baoHiemNhanVien)
        {
            string query = $"INSERT INTO BaoHiemNhanVien (MaNV, MaBH, NgayBD, NgayKT, NoiCap, GhiChu) " +
                           $"VALUES ('{baoHiemNhanVien.MaNV}', '{baoHiemNhanVien.MaBH}', " +
                           $"'{baoHiemNhanVien.NgayBD}', '{baoHiemNhanVien.NgayKT}', " +
                           $"N'{baoHiemNhanVien.NoiCap}', N'{baoHiemNhanVien.GhiChu}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(BaoHiemNhanVien baoHiemNhanVien)
        {
            string query = $"UPDATE BaoHiemNhanVien SET NgayBD = '{baoHiemNhanVien.NgayBD}', " +
                           $"NgayKT = '{baoHiemNhanVien.NgayKT}', NoiCap = N'{baoHiemNhanVien.NoiCap}', " +
                           $"GhiChu = N'{baoHiemNhanVien.GhiChu}' " +
                           $"WHERE MaNV = '{baoHiemNhanVien.MaNV}' AND MaBH = '{baoHiemNhanVien.MaBH}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maNV, string maBH)
        {
            string query = $"DELETE FROM BaoHiemNhanVien WHERE MaNV = '{maNV}' AND MaBH = '{maBH}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}