using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreManager
{
    public partial class DangNhap : MetroFramework.Forms.MetroForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            DangKy form = new DangKy();
            form.Show();
            this.BringToFront();
            this.Hide();
        }
    }
}
