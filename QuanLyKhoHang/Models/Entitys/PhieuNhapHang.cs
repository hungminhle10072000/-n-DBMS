using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class PhieuNhapHang
    {
        public PhieuNhapHang()
        {
            HangHoas = new HashSet<HangHoa>();
            HangNhaps = new HashSet<HangNhap>();
        }

        public string MaPhieu { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MoTa { get; set; }
        public string NhanVienNhap { get; set; }

        public virtual NhanVien NhanVienNhapNavigation { get; set; }
        public virtual ICollection<HangHoa> HangHoas { get; set; }
        public virtual ICollection<HangNhap> HangNhaps { get; set; }
    }
}
