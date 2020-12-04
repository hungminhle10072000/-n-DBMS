using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoHang.Common;
using QuanLyKhoHang.Views;
using QuanLyKhoHang.Views.NhanVien;
using QuanLyKhoHang.Views.QuanLy;

namespace QuanLyKhoHang
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                switch (Round.nhanVien.IdNhom)
                {
                    case "admin":
                        Application.Run(new frmQuanLyManHinhChinh());
                        break;
                    default:
                        Application.Run(new frmNhanVienManHinhChinh());
                        break;
                }
   
            }
           
        }
    }
}
