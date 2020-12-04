using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmQlThemDonXuatHang : Form
    {
        private frmQuanLyManHinhChinh _parent;
        public frmQlThemDonXuatHang(frmQuanLyManHinhChinh parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmQlChiTietDonXuatHang(_parent));
        }
    }
}
