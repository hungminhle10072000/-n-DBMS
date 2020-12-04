using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HangHoaMaNvNhapKhoNavigations = new HashSet<HangHoa>();
            HangHoaMaNvXuatKhoNavigations = new HashSet<HangHoa>();
            MatHangs = new HashSet<MatHang>();
            PhieuNhapHangs = new HashSet<PhieuNhapHang>();
            PhieuXuatHangs = new HashSet<PhieuXuatHang>();
        }

        public string IdNhom { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string QueQuan { get; set; }
        public string TenDangNhap { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string MatKhau { get; set; }
        public string SoCmnd { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }

        public virtual NhomNhanVien IdNhomNavigation { get; set; }
        public virtual ICollection<HangHoa> HangHoaMaNvNhapKhoNavigations { get; set; }
        public virtual ICollection<HangHoa> HangHoaMaNvXuatKhoNavigations { get; set; }
        public virtual ICollection<MatHang> MatHangs { get; set; }
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual ICollection<PhieuXuatHang> PhieuXuatHangs { get; set; }
    }
}
