using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QuanLyKhoHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views.NhanVien
{
    public partial class frmNvXuatHang : Form
    {
        private frmNhanVienManHinhChinh _parent;
        public frmNvXuatHang(frmNhanVienManHinhChinh parent)
        {
            InitializeComponent();
            _parent = parent;
            var context = new QLKHContext();
            dataGridView1.DataSource = context.NV_PhieuXuatHangs.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var context=new QLKHContext())
            {
                var parasearch = new SqlParameter("@SearchText", txtSearch.Text.Trim());
                dataGridView1.DataSource = context.NV_PhieuXuatHangs.FromSqlRaw("SearchNhanVienXuatHang @SearchText", parasearch).ToList();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*_parent.AddChild(new frmChiTietXuatHang(_parent, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));*/
            }
        }
    }
}
