using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
    internal class CheDoDAO
    {
        DataHandle _handle;

        public CheDoDAO()
        {
            _handle = new DataHandle();
        }

        public List<CheDo> GetAll()
        {
            List<CheDo> cheDos = new List<CheDo>();
            string query = "SELECT * FROM CheDo";
            DataTable dataTable = _handle.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                cheDos.Add(new CheDo()
                {
                    MaCD = row["MaCD"].ToString(),
                    TenCD = row["TenCD"].ToString()
                });
            }

            return cheDos;
        }

        public bool Insert(CheDo cheDo)
        {
            string query = $"INSERT INTO CheDo (MaCD, TenCD) " +
                           $"VALUES ('{cheDo.MaCD}', N'{cheDo.TenCD}')";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Update(CheDo cheDo, string maCD)
        {
            string query = $"UPDATE CheDo SET TenCD = N'{cheDo.TenCD}' " +
                           $"WHERE MaCD = '{maCD}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }

        public bool Delete(string maCD)
        {
            string query = $"DELETE FROM CheDo WHERE MaCD = '{maCD}'";
            bool result = _handle.ExecuteNonQuery(query);
            return result;
        }
    }
}