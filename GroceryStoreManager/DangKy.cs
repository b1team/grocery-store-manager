using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using GroceryStoreManager.Domains;
using MetroFramework;

namespace GroceryStoreManager
{
    public partial class DangKy : MetroFramework.Forms.MetroForm
    {
        private NguoiDung nguoiDung;
        private DatabaseContext db;
        private Quyen quuyenNguoiDung;
        public DangKy()
        {
            InitializeComponent();
        }

        internal NguoiDung NguoiDung { get => nguoiDung; set => nguoiDung = value; }
        internal Quyen QuuyenNguoiDung { get => quuyenNguoiDung; set => quuyenNguoiDung = value; }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(quuyenNguoiDung.Cap < 2)
            {
                MessageBox.Show("Bạn không đủ quyền để thêm người dùng", "Lỗi");
                return;
            }
            var tenDangNhap = txtTenDangNhap.Text.Trim().ToLower();
            if(tenDangNhap.Length < 3)
            {
                MessageBox.Show("Tên người dùng phải có ít nhất 3 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var matKhau = txtMatKhau.Text;
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var tenNguoiDung = txtTenNguoiDung.Text.Trim();
            var maQuyen = Convert.ToInt32(boxQuyen.SelectedValue);
            var nguoiDung = new NguoiDung()
            {
                MaQuyen = maQuyen,
                MatKhau = matKhau,
                TenDangNhap = tenDangNhap,
                TenNguoiDung = tenNguoiDung,
                NgayTao = DateTime.Now
            };
            db.DsNguoiDung.Add(nguoiDung);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Tạo người dùng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tạo người dùng thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Load_Quyen()
        {
            db = new DatabaseContext();
            try
            {
                db.DsQuyen.Load();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tải danh sách quyền");
                return;
            }
            boxQuyen.DataSource = db.DsQuyen.Local.ToBindingList();
            boxQuyen.ValueMember = "MaQuyen";
            boxQuyen.DisplayMember = "TenQuyen";
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            Load_Quyen();
        }
    }
}
