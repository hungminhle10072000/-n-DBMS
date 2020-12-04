using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class PhieuXuatHang
    {
        public PhieuXuatHang()
        {
            HangHoas = new HashSet<HangHoa>();
        }

        public string MaPhieu { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayXuatDuKien { get; set; }
        public DateTime NgayXuatThucTe { get; set; }
        public string NhanVienXuat { get; set; }

        public virtual NhanVien NhanVienXuatNavigation { get; set; }
        public virtual ICollection<HangHoa> HangHoas { get; set; }
    }
}
