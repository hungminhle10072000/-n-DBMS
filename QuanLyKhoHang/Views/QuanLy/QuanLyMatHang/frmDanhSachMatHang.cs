using QuanLyKhoHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmDanhSachMatHang : Form
    {
        private frmQuanLyManHinhChinh _parent;
        public frmDanhSachMatHang(frmQuanLyManHinhChinh parent)
        {
            InitializeComponent();
            var context = new QLKHContext();
            dataGridView1.DataSource = context.MatHangs.ToList();
            _parent = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmChiTietMatHang());
        }
    }
}
