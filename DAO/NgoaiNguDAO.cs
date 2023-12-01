using System;
using System.Collections.Generic;
using System.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.DAO
{
    internal class NgoaiNguDAO
    {
        DataHandle _handle;

        public NgoaiNguDAO()
        {
            _handle = new DataHandle();
        }
        public List<NgoaiNgu> GetAll()
        {
            List<NgoaiNgu> ngoaiNgus = new List<NgoaiNgu>();
            string query = "SELECT * FROM NgoaiNgu";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                ngoaiNgus.Add(new NgoaiNgu()
                {
                    MaNN = row["MaNN"].ToString(),
                    TenNN = row["TenNN"].ToString()
                });
            }

            return ngoaiNgus;
        }
        public List<NgoaiNgu> Get(string keyword)
        {
            List<NgoaiNgu> ngoaiNgus = new List<NgoaiNgu>();
            string query = $"SELECT * FROM NgoaiNgu WHERE MaNN LIKE '%{keyword}%' OR TenNN LIKE N'%{keyword}%'";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                ngoaiNgus.Add(new NgoaiNgu()
                {
                    MaNN = row["MaNN"].ToString(),
                    TenNN = row["TenNN"].ToString()
                });
            }

            return ngoaiNgus;
        }

        public bool InsertNgoaiNgu(string maNN, string tenNN)
        {
            string query = $"INSERT INTO NgoaiNgu (MaNN, TenNN) VALUES ('{maNN}', N'{tenNN}')";
            return _handle.ExecuteNonQuery(query);
        }


        public bool UpdateNgoaiNgu(string maNN, string tenNN)
        {
            string queryCheck = $"select * from [NgoaiNgu] where MaNN = N'{maNN}'";
            DataTable dataTable = _handle.ExecuteQuery(queryCheck);
            if (dataTable.Rows.Count > 0)
            {
                string query = $"UPDATE NgoaiNgu SET TenNN = N'{tenNN}' WHERE MaNN = '{maNN}'";
                return _handle.ExecuteNonQuery(query);
            }
            return false;

        }


        public bool DeleteNgoaiNgu(string maNN)
        {
            string query = $"DELETE FROM NgoaiNgu WHERE MaNN = '{maNN}'";
            return _handle.ExecuteNonQuery(query);
        }
    }
}