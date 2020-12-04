using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class MatHang
    {
        public MatHang()
        {
            HangHoas = new HashSet<HangHoa>();
            HangNhaps = new HashSet<HangNhap>();
        }

        public string MaMatHang { get; set; }
        public string NhaSanXuat { get; set; }
        public string TenMatHang { get; set; }
        public string MoTa { get; set; }
        public decimal? GiaTri { get; set; }
        public string NvTao { get; set; }

        public virtual NhanVien NvTaoNavigation { get; set; }
        public virtual ICollection<HangHoa> HangHoas { get; set; }
        public virtual ICollection<HangNhap> HangNhaps { get; set; }
    }
}
