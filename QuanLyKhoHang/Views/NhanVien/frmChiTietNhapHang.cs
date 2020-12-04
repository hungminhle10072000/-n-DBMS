using Microsoft.Data.SqlClient;
using QuanLyKhoHang.Models;
using QuanLyKhoHang.Models.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace QuanLyKhoHang.Views.NhanVien
{
    public partial class frmChiTietXuatHang : Form
    {
        private Form _parent;
        private viewNhanVienNhapHang _NhanVienNhapHang;
        public frmChiTietXuatHang(Form parent, string mdh)
        {

            InitializeComponent();
           /* _parent = parent;
            var context = new QLKHContext();
            var mdhparameter = new SqlParameter("@madonhang", mdh);
            _NhanVienNhapHang = context.NhanVienNhapHangs.FromSqlRaw("getNV_DonNhapHang @madonhang", mdhparameter).ToList().FirstOrDefault();
            txtMdh.Text = _NhanVienNhapHang.MaPhieu.ToString();
            txtNhapTu.Text = _NhanVienNhapHang.NhapTu.ToString();
            txtNgayTaoPhieu.Text = _NhanVienNhapHang.NgayNhap.ToString();
            txtTenNhanVienTao.Text = _NhanVienNhapHang.TenNhanVien.ToString();
            rMoTa.Text = _NhanVienNhapHang.MoTa.ToString();
            dataGridView1.DataSource =context.NV_ChiTietHangHoaTrongDon.FromSqlRaw("Proc_NV_ChiTietDonHang @madonhang", mdhparameter).ToList();*/
        }

        private void btnLuuKho_Click(object sender, EventArgs e)
        {
           /* var context = new QLKHContext();
            List<SqlParameter> NV_ThemHangHoa = new List<SqlParameter>();
            NV_ThemHangHoa.Add(new SqlParameter("@mahanghoa",txtMaHangHoa.Text));
            NV_ThemHangHoa.Add(new SqlParameter("@hansudung",dtpHsd.Value.ToString("yyyy-MM-dd")));
            NV_ThemHangHoa.Add(new SqlParameter("@ngaysanxuat",dtpNsx.Value.ToString("yyyy-MM-dd")));
            NV_ThemHangHoa.Add(new SqlParameter("@vitri", txtViTri.Text));
            NV_ThemHangHoa.Add(new SqlParameter("@ngaynhapkho", dtpNgayNhapKho.Value.ToString("yyyy-MM-dd")));
            NV_ThemHangHoa.Add(new SqlParameter("@mamathang", txtMaMatHang.Text));
            NV_ThemHangHoa.Add(new SqlParameter("@mdh", txtMdh.Text));
            NV_ThemHangHoa.Add(new SqlParameter("@MaNV_NhapKho", txtMaNV_nhapkho.Text));
            NV_ThemHangHoa.Add(new SqlParameter("@matinhtrang", comboBox1.Text));
            context.Database.ExecuteSqlRaw("NV_ThemHangHoa @mahanghoa,@hansudung,@ngaysanxuat,@vitri,@ngaynhapkho,@mamathang,@mdh,@MaNV_NhapKho,@matinhtrang", NV_ThemHangHoa);*/
            frmLuuKho luukho = new frmLuuKho();
            luukho.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtMaMatHang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();*/
        }

        private void txtMaMatHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
