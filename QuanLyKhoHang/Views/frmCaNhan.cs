using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyKhoHang.Views.NhanVien;
using QuanLyKhoHang.Views.QuanLy;

namespace QuanLyKhoHang.Views
{
    public partial class frmCaNhan : Form
    {
        private frmQuanLyManHinhChinh _parent;
        private frmNhanVienManHinhChinh _parent1;
        public frmCaNhan(frmQuanLyManHinhChinh parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public frmCaNhan(frmNhanVienManHinhChinh parent)
        {
            InitializeComponent();
            _parent1 = parent;
        }
        private void frmCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnMatKhau_Click(object sender, EventArgs e)
        {
            if(_parent!=null)
            _parent.AddChild(new frmMatKhau());
            else if (_parent1 != null)
            {
                _parent1.AddChild(new frmMatKhau());
            }
        }
    }
}
