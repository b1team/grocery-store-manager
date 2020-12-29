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
    public partial class NhapHang : MetroFramework.Forms.MetroForm
    {
        private NguoiDung nguoiDung;
        private Quyen quyen;
        private DatabaseContext db;

        internal NguoiDung NguoiDung { get => nguoiDung; set => nguoiDung = value; }
        internal Quyen Quyen { get => quyen; set => quyen = value; }
        private List<Model.ChiTietPhieuNhap> SelectedItems = new List<Model.ChiTietPhieuNhap>();

        public NhapHang()
        {
            InitializeComponent();
        }

        private void cellClickHander(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridTimHang.Rows[e.RowIndex];
            var item = new Model.ChiTietPhieuNhap(Convert.ToString(row.Cells[0].Value), row.Cells[1].Value.ToString(), 0, 1);

            int rows = gridChiTietPN.Rows.Count;
            var existed = false;
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row1 = gridChiTietPN.Rows[i];
                if (row1.Cells["MaHang"].Value.ToString() == item.MaHang)
                {
                    row1.Cells["SoLuong"].Value = (int)row1.Cells["SoLuong"].Value + 1;
                    row1.Cells["ThanhTien"].Value = Model.ChiTietPhieuNhap.ThanhToan((int)row1.Cells["GiaNhap"].Value, (int)row1.Cells["SoLuong"].Value);
                    existed = true;
                    break;
                }
            }
            if (!existed)
            {
                SelectedItems.Add(item);

            }
            gridChiTietPN.DataSource = new List<Model.ChiTietPhieuNhap>();
            gridChiTietPN.DataSource = SelectedItems;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();
            txtNguoiNhap.Text = nguoiDung.TenNguoiDung;
            Load_NCC();
        }

        private void insert()
        {
        }

        private void Load_NCC()
        {
            db = new DatabaseContext();
            try
            {
                db.DsNhaCungCap.Load();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tải danh sách nhà cung cấp");
                return;
            }
            boxNCC.DataSource = db.DsNhaCungCap.Local.ToBindingList();
            boxNCC.ValueMember = "MaNCC";
            boxNCC.DisplayMember = "TenNCC";
        }

        private void txtTimHang_TextChanged(object sender, EventArgs e)
        {
            db.DsMatHang.Load();
            var data = db.DsMatHang.Local.ToBindingList().Where(hang => hang.DangKinhDoanh.Equals(true) && hang.TenHang.ToLower().Trim().Contains(txtTimHang.Text));
            gridTimHang.DataSource = data.ToList();
        }


        private void tinh_lai_thanh_tien(object sender, DataGridViewRowsAddedEventArgs e)
        {
            MessageBox.Show("ahihi");
        }
    }
}
