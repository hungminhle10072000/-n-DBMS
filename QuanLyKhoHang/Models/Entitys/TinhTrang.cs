using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class TinhTrang
    {
        public string MaTinhTrang { get; set; }
        public string TenTinhTrang { get; set; }
        public string MaHangHoa { get; set; }

        public virtual HangHoa MaHangHoaNavigation { get; set; }
    }
}
