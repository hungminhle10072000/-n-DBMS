using QuanLyKhoHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmChiTietDonNhapHang : Form
    {
        private viewDanhsachNhapHang _phieunhaphang;
        private Form _parent;
        public frmChiTietDonNhapHang(Form parent,string maphieuhang)
        {
            InitializeComponent();
            _parent = parent;
            var context = new QLKHContext();
            var maphieuparam = new SqlParameter("@maphieunhanhang", maphieuhang);
            _phieunhaphang = context.DanhsachNhapHangs.FromSqlRaw("getDonNhapHang @maphieunhanhang",maphieuparam).ToList().FirstOrDefault();
            txtMaPhieu.Text = _phieunhaphang.MaPhieu;
            txtNgayTao.Text = _phieunhaphang.NgayNhap.ToString();
            txtNhapTu.Text = _phieunhaphang.NhapTu;
            txtTongTien.Text = _phieunhaphang.GiaTri.ToString();
            txtNguoiTao.Text = _phieunhaphang.NhanVienNhap;
            rtMoTa.Text = _phieunhaphang.MoTa;

            dataGridMatHang.DataSource = context.DanhSachMatHangNhapKhos.Where(x => x.MaPhieu == maphieuhang).ToList();
            dataGridMatHang.Columns["MaPhieu"].Visible = false;
            dataGridHangHoa.DataSource = context.HangHoas.Where(x => x.MpNhapHang == maphieuhang).ToList();
            dataGridHangHoa.Columns["MaNvKiemKe"].Visible = false;
            dataGridHangHoa.Columns["NgayKiemKe"].Visible = false;
            dataGridHangHoa.Columns["MaMatHang"].Visible = false;
            dataGridHangHoa.Columns["MpNhapHang"].Visible = false;
            dataGridHangHoa.Columns["MpXuatHang"].Visible = false;
            dataGridHangHoa.Columns["MaNvXuatKho"].Visible = false;
            dataGridHangHoa.Columns["MaMatHangNavigation"].Visible = false;
            dataGridHangHoa.Columns["MaNvNhapKhoNavigation"].Visible = false;
            dataGridHangHoa.Columns["MaNvXuatKhoNavigation"].Visible = false;
            dataGridHangHoa.Columns["MpNhapHangNavigation"].Visible = false;
            dataGridHangHoa.Columns["MpXuatHangNavigation"].Visible = false;
            dataGridHangHoa.Columns["TinhTrangs"].Visible = false;
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
