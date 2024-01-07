using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class ChamCongDAO
    {
        DataHandle _handle;

        public ChamCongDAO()
        {
            _handle = new DataHandle();
        }
        public List<ChamCong> Get(string maNV)
        {
            List<ChamCong> chamCongs = new List<ChamCong>();
            string query =
                $"select * from [ChamCong] where maNV = N'{maNV}'";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                chamCongs.Add(new ChamCong()
                {
                    MaCC = int.Parse(row["MaCC"].ToString()),
                    MaNV = row["MaNV"].ToString(),
                    NgayCham = DateTime.Parse(row["NgayCham"].ToString()),
                    Checkin = TimeSpan.Parse(row["Checkin"].ToString()),
                    Checkout = TimeSpan.Parse(row["Checkout"].ToString()),
                    GhiChu = row["GhiChu"].ToString()
                });
            }

            return chamCongs;
        }
        public List<ChamCong> GetAll()
        {
            List<ChamCong> chamCongs = new List<ChamCong>();
            string query =
                "SELECT * FROM ChamCong";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                chamCongs.Add(new ChamCong()
                {
                    MaCC = int.Parse(row["MaCC"].ToString()),
                    MaNV = row["MaNV"].ToString(),
                    NgayCham = DateTime.Parse(row["NgayCham"].ToString()),
                    Checkin = TimeSpan.Parse(row["Checkin"].ToString()),
                    Checkout = TimeSpan.Parse(row["Checkout"].ToString()),
                    GhiChu = row["GhiChu"].ToString()
                });
            }

            return chamCongs;
        }

        public bool Insert(ChamCong chamCong)
        {
            string query = $"INSERT INTO ChamCong ( MaNV, NgayCham, Checkin, Checkout, GhiChu) " +
                           $"VALUES (" +
                           $"'{chamCong.MaNV}', " +
                           $"'{chamCong.NgayCham}', " +
                           $"'{chamCong.Checkin}', " +
                           $"N'{chamCong.Checkout}'," +
                           $" N'{chamCong.GhiChu}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(ChamCong chamCong)
        {
            string query = $"UPDATE ChamCong SET MaNV = '{chamCong.MaNV}', " +
                           $"NgayCham = '{chamCong.NgayCham}'," +
                           $"Checkin = N'{chamCong.Checkin}', " +
                           $"Checkout = N'{chamCong.Checkout}', " +
                           $"GhiChu = N'{chamCong.GhiChu}' " +
                           $"WHERE MaCC = '{chamCong.MaCC}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(int MaCC)
        {
            string query = $"DELETE FROM ChamCong WHERE MaCC = '{MaCC}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}
