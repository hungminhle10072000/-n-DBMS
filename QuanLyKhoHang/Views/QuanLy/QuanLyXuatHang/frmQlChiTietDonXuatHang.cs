using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmQlChiTietDonXuatHang : Form
    {
        private frmQuanLyManHinhChinh _parent;
        public frmQlChiTietDonXuatHang(frmQuanLyManHinhChinh parent)
        {
            InitializeComponent();
            _parent = parent;
        }
    }
}
