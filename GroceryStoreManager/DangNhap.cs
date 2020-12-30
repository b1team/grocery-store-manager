using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStoreManager.Domains;

namespace GroceryStoreManager
{
    public partial class DangNhap : MetroFramework.Forms.MetroForm
    {
        private DatabaseContext db;
        private NguoiDung nguoiDung;
        private Quyen quyen;
        public DangNhap()
        {
            InitializeComponent();
        }
        public int RoleLevel = 0;

        internal NguoiDung NguoiDung { get => nguoiDung;}
        internal Quyen Quyen { get => quyen;}

        private void DangNhap_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();
            this.ActiveControl = txtTenDangNhap;
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            DangKy form = new DangKy();
            this.Hide();
            form.ShowDialog();
            this.BringToFront();
            this.Show();
        }

        private void BatDauDangNhap()
        {
            var tenDangNhap = txtTenDangNhap.Text.Trim().ToLower();
            var matKhau = txtMatKhau.Text;
            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var query = (from u in db.DsNguoiDung join r in db.DsQuyen on u.MaQuyen equals r.MaQuyen where u.TenDangNhap == tenDangNhap where u.MatKhau == matKhau select new { u = u, r = r });
            try
            {
                var user = query.FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.RoleLevel = user.r.Cap;
                    this.quyen = user.r;
                    this.nguoiDung = user.u;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Đang nâng cấp hệ thống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BatDauDangNhap();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void pressEnterHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BatDauDangNhap();
            }
        }
    }
}
