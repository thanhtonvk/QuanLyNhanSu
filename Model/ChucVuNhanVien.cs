using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    internal class ChucVuNhanVien
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public string TenCV { get;set; }
        public DateTime? NgayBD { get; set; }
        public DateTime? NgayKT { get; set; }
    }
}
