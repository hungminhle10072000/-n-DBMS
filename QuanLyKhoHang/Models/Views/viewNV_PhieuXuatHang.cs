using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoHang.Models.Views
{
    public class viewNV_PhieuXuatHang
    {
        public string MaPhieu { get; set; }
        public string MoTa { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime NgayXuat_DuKien { get; set; }

        public string TenNhanVien { get; set; }
    }
}
