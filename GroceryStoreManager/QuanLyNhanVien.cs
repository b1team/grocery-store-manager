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

namespace GroceryStoreManager
{
    public partial class QuanLyNhanVien : UserControl
    {
        private DatabaseContext db;
        private NguoiDung nguoiDung;
        private Quyen quyenNguoiDung;
        private static QuanLyNhanVien _instance;
        public static QuanLyNhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QuanLyNhanVien();
                return _instance;
            }
        }

        internal NguoiDung NguoiDung { get => nguoiDung; set => nguoiDung = value; }
        internal Quyen QuyenNguoiDung { get => quyenNguoiDung; set => quyenNguoiDung = value; }

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();
            LoadData();   
        }

        private void LoadData()
        {
            db.DsNguoiDung.Load();
            gridNguoiDung.DataSource = db.DsNguoiDung.Local.ToBindingList();
            quyenBindingSource.DataSource = db.DsQuyen.ToList();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show("Cập nhật thông tin thành công", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong khi cập nhật", "Cập nhật không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            DangKy form = new DangKy();
            form.NguoiDung = nguoiDung;
            form.QuuyenNguoiDung = quyenNguoiDung;
            form.ShowDialog();
        }

        private void searchHandle(object sender, EventArgs e)
        {
            var query = txtTimNhanVien.Text.Trim().ToLower();
            BindingSource data = new BindingSource();
            data.DataSource = db.DsNguoiDung.Where(u => (u.TenNguoiDung.Contains(query) || u.TenDangNhap.Contains(query) || u.MaNguoiDung.ToString().Contains(query))).ToList();
            gridNguoiDung.DataSource = data;
            quyenBindingSource.DataSource = db.DsQuyen.ToList();
        }
    }
}
