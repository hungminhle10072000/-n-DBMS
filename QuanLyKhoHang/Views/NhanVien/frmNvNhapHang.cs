using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using QuanLyKhoHang.Models;


namespace QuanLyKhoHang.Views.NhanVien
{
    public partial class frmNvNhapHang : Form
    {
        private frmNhanVienManHinhChinh _parent;

        public frmNvNhapHang(frmNhanVienManHinhChinh parent)
        {
            _parent = parent;
            InitializeComponent();
            var context =new  QLKHContext();
            dataGridView1.DataSource = context.NhanVienNhapHangs.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using(var context= new QLKHContext())
            {
                var parasearch = new SqlParameter("@SearchText", txtSearch.Text.Trim());
                dataGridView1.DataSource = context.NhanVienNhapHangs.FromSqlRaw("SearchNhanVienNhapHang @SearchText", parasearch).ToList();
            }
        }

        private void frmNvNhapHang_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                _parent.AddChild(new frmChiTietXuatHang(_parent, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
        }
    }
}
