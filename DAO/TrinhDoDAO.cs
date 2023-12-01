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
        public List<TrinhDo> GetAll()
        {
            List<TrinhDo> list = new List<TrinhDo>();
            string query = "SELECT * FROM TrinhDo";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(new TrinhDo()
                {
                    MaTD = row["MaTD"].ToString(),
                    TenTD = row["TenTD"].ToString()
                });
            }

            return list;
        }
        public bool Insert(TrinhDo trinhDo)
        {
            string insertQuery = $"INSERT INTO TrinhDo (MaTD, TenTD) VALUES (N'{trinhDo.MaTD}', N'{trinhDo.TenTD}')";
            bool result = _handle.ExecuteNonQuery(insertQuery);
            return result;
        }

        public bool Update(TrinhDo trinhDo)
        {

            string queryCheck = $"select * from [TrinhDo] where MaTD = N'{trinhDo.MaTD}'";
            DataTable dataTable = _handle.ExecuteQuery(queryCheck);
            if (dataTable.Rows.Count > 0)
            {
                string insertQuery = $"Update TrinhDo set TenTD = N'{trinhDo.TenTD}' where MaTD = '{trinhDo.MaTD}'";
                bool result = _handle.ExecuteNonQuery(insertQuery);
                return result;
            }
            return false;
        }

        public bool Delete(string maTd)
        {
            string insertQuery = $"DELETE TrinhDo where MaTD = '{maTd}'";
            bool result = _handle.ExecuteNonQuery(insertQuery);
            return result;
        }
    }
}