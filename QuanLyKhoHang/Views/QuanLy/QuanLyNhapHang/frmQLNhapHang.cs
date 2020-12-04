 using QuanLyKhoHang.Models;
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

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmQLNhapHang : Form
    {
        private frmQuanLyManHinhChinh _parent;
        public frmQLNhapHang(frmQuanLyManHinhChinh parent)
        {
            _parent = parent;
            InitializeComponent();
            var context = new QLKHContext();
            dataGridView1.DataSource = context.DanhsachNhapHangs.ToList();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
                _parent.AddChild(new frmChiTietDonNhapHang(_parent,dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new QLKHContext())
            {
                var paramSearch = new SqlParameter("@searchtext", txtSearch.Text.Trim());
                dataGridView1.DataSource = context.DanhsachNhapHangs.FromSqlRaw("SearchDonNhanHang @searchtext", paramSearch).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmThemDonNhapHang(_parent));
        }
    }
}
