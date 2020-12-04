using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class HangHoa
    {
        public HangHoa()
        {
            TinhTrangs = new HashSet<TinhTrang>();
        }

        public string MaHangHoa { get; set; }
        public string MaNvKiemKe { get; set; }
        public DateTime NgayKiemKe { get; set; }
        public DateTime HanSuDung { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public string ViTri { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public string MaMatHang { get; set; }
        public string MpNhapHang { get; set; }
        public string MpXuatHang { get; set; }
        public string MaNvNhapKho { get; set; }
        public string MaNvXuatKho { get; set; }

        public virtual MatHang MaMatHangNavigation { get; set; }
        public virtual NhanVien MaNvNhapKhoNavigation { get; set; }
        public virtual NhanVien MaNvXuatKhoNavigation { get; set; }
        public virtual PhieuNhapHang MpNhapHangNavigation { get; set; }
        public virtual PhieuXuatHang MpXuatHangNavigation { get; set; }
        public virtual ICollection<TinhTrang> TinhTrangs { get; set; }
    }
}
