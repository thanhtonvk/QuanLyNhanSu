using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class PhongBanDAO
    {
        DataHandle _handle;

        public PhongBanDAO()
        {
            _handle = new DataHandle();
        }

        public List<PhongBan> GetAll()
        {
            List<PhongBan> phongBans = new List<PhongBan>();
            string query = "SELECT * FROM PhongBan";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                phongBans.Add(new PhongBan()
                {
                    MaPB = row["MaPB"].ToString(),
                    TenPB = row["TenPB"].ToString()
                });
            }

            return phongBans;
        }

        public bool Insert(PhongBan phongBan)
        {
            string query = $"INSERT INTO PhongBan (MaPB, TenPB) VALUES ('{phongBan.MaPB}', N'{phongBan.TenPB}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(PhongBan phongBan)
        {
            string query = $"UPDATE PhongBan SET TenPB = N'{phongBan.TenPB}' WHERE MaPB = '{phongBan.MaPB}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maPB)
        {
            string query = $"DELETE FROM PhongBan WHERE MaPB = '{maPB}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}