using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class NhomNhanVien
    {
        public NhomNhanVien()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public string Id { get; set; }
        public string TenNhom { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
