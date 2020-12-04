using QuanLyKhoHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Data.SqlClient;
using QuanLyKhoHang.Common;

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmThemDonNhapHang : Form
    {
        private frmQuanLyManHinhChinh _parent;
        public frmThemDonNhapHang(frmQuanLyManHinhChinh parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            var context = new QLKHContext();
            List<SqlParameter> PhieuNhapHangParameters = new List<SqlParameter>();
            PhieuNhapHangParameters.Add(new SqlParameter("@maphieu", txtMaDonHang.Text));
            PhieuNhapHangParameters.Add(new SqlParameter("@NgayNhap", DateTime.Now.ToString("yyyy-MM-dd")));
            PhieuNhapHangParameters.Add(new SqlParameter("@mota", rtMoTa.Text));
            PhieuNhapHangParameters.Add(new SqlParameter("@nhanvien_nhap", Round.nhanVien.MaNhanVien));
            context.Database.ExecuteSqlRaw("ThemPhieuNhap @maphieu, @NgayNhap, @mota, @nhanvien_nhap", PhieuNhapHangParameters);
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    List<SqlParameter> hangnhapPara = new List<SqlParameter>();
                    hangnhapPara.Add(new SqlParameter("@soluong", item.Cells[2].Value));
                    hangnhapPara.Add(new SqlParameter("@mpnhap", txtMaDonHang.Text));
                    hangnhapPara.Add(new SqlParameter("@mahangnhap", item.Cells[0].Value));
                    context.Database.ExecuteSqlRaw("ThemHangNhap @soluong, @mpnhap, @mahangnhap", hangnhapPara);
                }
            }
            _parent.AddChild(new frmChiTietDonNhapHang(_parent, txtMaDonHang.Text));
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var context = new QLKHContext();
            switch(e.ColumnIndex)
            {
                case 0:
                    var paramMaMatHang = new SqlParameter("@mamathang", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    var temp = context.MatHangs.FromSqlRaw("TimMatHangTheoMa @mamathang", paramMaMatHang).ToList();
                    if (temp.Count > 0)
                    {
                        var mathang = temp[0];
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = mathang.TenMatHang.ToString();
                        if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
                            dataGridView1.Rows[e.RowIndex].Cells[3].Value = mathang.GiaTri * int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                    break;
                case 2:

                    break;
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                if(MessageBox.Show("Bạn có thực sự muốn xóa?","Cảnh báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
            }

        }
    }
}
