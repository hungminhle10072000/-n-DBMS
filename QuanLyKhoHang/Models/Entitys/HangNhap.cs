using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class HangNhap
    {
        public int SoLuong { get; set; }
        public string MpNhap { get; set; }
        public string MaHangNhap { get; set; }

        public virtual MatHang MaHangNhapNavigation { get; set; }
        public virtual PhieuNhapHang MpNhapNavigation { get; set; }
    }
}
