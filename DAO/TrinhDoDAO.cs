using System.Collections.Generic;
using System.Data;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.DAO
{
    public class TrinhDoDAO
    {
        private DataHandle _handle;

        public TrinhDoDAO()
        {
            _handle = new DataHandle();
        }

        public List<TrinhDo> Gets(string keyword)
        {
            List<TrinhDo> trinhDoList = new List<TrinhDo>();
            string selectQuery = $"SELECT * FROM TrinhDo where TenTD like N'%{keyword}%'";
            DataTable dataTable = _handle.ExecuteQuery(selectQuery);
            foreach (DataRow row in dataTable.Rows)
            {
                TrinhDo trinhDo = new TrinhDo
                {
                    MaTD = row["MaTD"].ToString(),
                    TenTD = row["TenTD"].ToString()
                };
                trinhDoList.Add(trinhDo);
            }

            return trinhDoList;
        }

        public bool Insert(TrinhDo trinhDo)
        {
            string insertQuery = $"INSERT INTO TrinhDo (MaTD, TenTD) VALUES (N'{trinhDo.MaTD}', N'{trinhDo.TenTD}')";
            bool result = _handle.ExecuteNonQuery(insertQuery);
            return result;
        }

        public bool Update(TrinhDo trinhDo, string maTd)
        {
            string insertQuery = $"Update TrinhDo set TenTD = N'{trinhDo.TenTD}' where MaTD = '{maTd}'";
            bool result = _handle.ExecuteNonQuery(insertQuery);
            return result;
        }

        public bool Delete(string maTd)
        {
            string insertQuery = $"DELETE TrinhDo where MaTD = '{maTd}'";
            bool result = _handle.ExecuteNonQuery(insertQuery);
            return result;
        }
    }
}