using System;
using System.Timers;

namespace QuanLyNhanSu.Model
{
    internal class ChamCong
    {
        public int MaCC { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayCham { get; set; }
        public TimeSpan Checkin { get; set; }
        public TimeSpan Checkout { get; set; }
        public string GhiChu { get; set; }
    }
}
