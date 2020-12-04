using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views.QuanLy
{
    public partial class frmQuanLyManHinhChinh : Form
    {
        private Form currentForm;
        public frmQuanLyManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnMenuNhapHang_Click(object sender, EventArgs e)
        {
            frmQLNhapHang QLNhapHang = new frmQLNhapHang(this);

            AddChild(QLNhapHang);
        }
        public void AddChild(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Visible = false;
            }
            currentForm = form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            this.pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void btnMenuXuatHang_Click(object sender, EventArgs e)
        {
            AddChild(new frmQlXuatHang(this));
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            AddChild(new frmDanhSachMatHang(this));
        }

        private void btnMenuKiemKe_Click(object sender, EventArgs e)
        {
            AddChild(new frmKiemKe(this));
        }

        private void btnHangTonKho_Click(object sender, EventArgs e)
        {
            AddChild(new frmQlHangTonKho());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AddChild(new frmQlNhanVien());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            AddChild(new frmThongKe());
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            AddChild(new frmCaNhan(this));
        }
    }
}
