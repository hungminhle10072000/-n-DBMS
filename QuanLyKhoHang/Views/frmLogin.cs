using Microsoft.Data.SqlClient;
using QuanLyKhoHang.Common;
using Microsoft.EntityFrameworkCore;
using QuanLyKhoHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace QuanLyKhoHang.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new QLKHContext();
            var paramUserName = new SqlParameter("@username",txtUserName.Text.Trim());
            var paramPassword= new SqlParameter("@password", txtUserName.Text.Trim());
            var nv = context.NhanViens.FromSqlRaw("Login @username, @password",paramUserName,paramPassword).ToList();
            
            if (nv.Count != 0)
            {
                Round.nhanVien = nv[0];
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Round.nhanVien = null;
                MessageBox.Show("Xin kiểm tra lại!", "Có lỗi");
                return;
            }
        }
    }
}
