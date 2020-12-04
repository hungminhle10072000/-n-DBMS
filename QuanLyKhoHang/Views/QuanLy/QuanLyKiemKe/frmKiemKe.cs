using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmKiemKe : Form
    {
        private frmQuanLyManHinhChinh _parent;
        public frmKiemKe(frmQuanLyManHinhChinh parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmDatLichKiemKe());
        }

        private void btnKiemKeToanBo_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmKiemKeToanBo());
        }

        private void btnKiemKeTheoMatHang_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmKiemKeTheoMatHang());
        }

        private void btnKiemKeTheoDonNhap_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmKiemKeTheoDonNhap());
        }
    }
}
