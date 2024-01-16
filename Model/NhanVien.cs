using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    internal class NhanVien
    {
        public static string ConstMaNV;
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string HinhAnh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int GioiTinh { get; set; }
        public string SoCCCD { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string SDTRieng { get; set; }
        public string SDTNha { get; set; }
        public string TinhTrangHonNhan { get; set; }
        public string MaPB { get; set; }
        public string MaTD { get; set; }
        public string MaBL { get; set; }
    }
}
