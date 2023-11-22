using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    internal class CheDoNhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaCD { get; set; }
        public string TenCD { get; set; }
        public DateTime? NgayBD { get; set; }
        public DateTime? NgayKT { get; set; }
    }
}