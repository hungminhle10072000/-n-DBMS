using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace QuanLyKhoHang.Models.Views
{
    public class viewNhanVienNhapHang
    {
        public string MaPhieu { get; set; }
        public string MoTa { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime NgayNhap { get; set; }
        public string TenNhanVien { get; set; }

        public string NhapTu { get; set; }
    }
}
