using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmQlXuatHang : Form
    {
        private frmQuanLyManHinhChinh _parent;
        public frmQlXuatHang(frmQuanLyManHinhChinh parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parent.AddChild(new frmQlThemDonXuatHang(_parent));
        }
    }
}
