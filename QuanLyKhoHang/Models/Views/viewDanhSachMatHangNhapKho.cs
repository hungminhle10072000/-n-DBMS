using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoHang.Models.Views
{
    public class viewDanhSachMatHangNhapKho
    {
        public string MaPhieu { get; set; }
        public string MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public decimal GiaTri { get; set; }
        public int Soluong { get; set; }
        public int? SoLuongNhapKho { get; set; } 
        public int? SoLuongLoai { get; set; } 
        public int? SoLuongChuaXuLy { get; set; } 
    }
}
