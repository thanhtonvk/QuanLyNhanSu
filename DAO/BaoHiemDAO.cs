using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class BaoHiemDAO
    {
        DataHandle _handle;

        public BaoHiemDAO()
        {
            _handle = new DataHandle();
        }

        public List<BaoHiem> GetAll()
        {
            List<BaoHiem> baoHiems = new List<BaoHiem>();
            string query = "SELECT * FROM BaoHiem";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                baoHiems.Add(new BaoHiem()
                {
                    MaBH = row["MaBH"].ToString(),
                    TenBH = row["TenBH"].ToString()
                });
            }

            return baoHiems;
        }

        public bool Insert(BaoHiem baoHiem)
        {
            string query = $"INSERT INTO BaoHiem (MaBH, TenBH) VALUES ('{baoHiem.MaBH}', N'{baoHiem.TenBH}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(BaoHiem baoHiem)
        {
            string query = $"UPDATE BaoHiem SET TenBH = N'{baoHiem.TenBH}' WHERE MaBH = '{baoHiem.MaBH}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maBH)
        {
            string query = $"DELETE FROM BaoHiem WHERE MaBH = '{maBH}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}