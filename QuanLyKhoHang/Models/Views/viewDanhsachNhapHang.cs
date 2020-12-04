using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoHang.Models
{
    public class viewDanhsachNhapHang
    {
        public string MaPhieu { get; set; }
        public string MoTa { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime NgayNhap { get; set; }
        public string NhapTu { get; set; }
        public string NhanVienNhap { get; set; }
        public decimal GiaTri { get; set; }
    }
}
