using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views.NhanVien
{
    public partial class frmNhanVienManHinhChinh : Form
    {
        private Form currentForm;
        public frmNhanVienManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            AddChild(new frmNvNhapHang(this));
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

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            AddChild(new frmNvXuatHang(this));
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            AddChild(new frmCaNhan(this));
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            AddChild(new frmNvKiemKe());
        }
    }
}
