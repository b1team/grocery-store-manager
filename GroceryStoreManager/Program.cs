using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DangNhap loginForm = new DangNhap();
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                if(loginForm.RoleLevel > 1)
                {
                    Home form = new Home();
                    form.NguoiDung = loginForm.NguoiDung;
                    form.QuuyenNguoiDung = loginForm.Quyen;
                    Application.Run(form);
                }
                else if(loginForm.RoleLevel == 1)
                {
                    BanHang form = new BanHang();
                    form.ThuNgan = loginForm.NguoiDung;
                    form.Quyen = loginForm.Quyen;
                    Application.Run(form);
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
