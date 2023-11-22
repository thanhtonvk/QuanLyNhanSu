using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    internal class BaoHiemNhanVien
    {
        public string MaNV { get; set; }
        public string MaBH { get; set; }
        public string TenBH { get; set; }
        public DateTime? NgayBD { get; set; }
        public DateTime? NgayKT { get; set; }
        public string NoiCap { get; set; }
        public string GhiChu { get; set; }
    }
}
