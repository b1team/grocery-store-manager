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
            if(e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = gridTimHang.Rows[e.RowIndex];
            var item = new Model.ChiTietPhieuNhap(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString(), 0, 1);

            int rows = gridChiTietPN.Rows.Count;
            var existed = false;
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row1 = gridChiTietPN.Rows[i];
                if (Convert.ToInt32(row1.Cells["MaHang"].Value) == item.MaHang)
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
            txtThanhTien.Text = "0";
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
            double TongThanhTien = 0;
            
            foreach(DataGridViewRow row in gridChiTietPN.Rows)
            {
                var s = Convert.ToDouble(row.Cells["GiaNhap"].Value) * Convert.ToInt32(row.Cells["SoLuong"].Value);
                row.Cells["ThanhTien"].Value = s;
                TongThanhTien += s;
            }
            txtThanhTien.Text = TongThanhTien.ToString();
        }

        private void gridChiTietPN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = gridChiTietPN.Rows[e.RowIndex];
            var soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
            var giaNhap = Convert.ToDouble(row.Cells["GiaNhap"].Value);
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải >0");
                row.Cells["SoLuong"].Value = 1;
                return;
            }
            if (giaNhap < 0)
            {
                MessageBox.Show("Giá nhập không được < 0");
                row.Cells["GiaNhap"].Value = 0;
                return;
            }
            var thanh_tien_cu = Convert.ToDouble(row.Cells["ThanhTien"].Value);
            var thanh_tien_moi = giaNhap * soLuong;
            row.Cells["ThanhTien"].Value = thanh_tien_moi;
            txtThanhTien.Text = (Convert.ToDouble(txtThanhTien.Text) + (thanh_tien_moi - thanh_tien_cu)).ToString();
        }


        private void TaoPhieuNhap()
        {
            DateTime NgayTao = dtNgayNhap.Value;
            bool DaThanhToan = checkboxDaThanhToan.Checked;
            float thanhTien = (float)Convert.ToDouble(txtThanhTien.Text.Trim());
            int maNCC = Convert.ToInt32(boxNCC.SelectedValue);
            PhieuNhap phieuNhap = new PhieuNhap()
            {
                MaNCC = maNCC,
                NgayTao = NgayTao,
                DaThanhToan = DaThanhToan,
                ThanhTien = thanhTien
            };
            foreach (var item in SelectedItems)
            {
                var hang = db.DsMatHang.Find(item.MaHang);
                hang.SoLuong += item.SoLuong;
                ChiTietPN chitietPN = new ChiTietPN()
                {
                    SoLuong = item.SoLuong,
                    DonGia = item.GiaNhap,
                    ThanhTien = item.ThanhTien
                };
                chitietPN.MatHang = hang;
                chitietPN.PhieuNhap = phieuNhap;
                db.DsChiTietPN.Add(chitietPN);
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if(gridChiTietPN.Rows.Count == 0)
            {
                MessageBox.Show("Không có hàng nào để nhập");
                return;
            }
            TaoPhieuNhap();
            try
            {
                db.SaveChanges();
                MessageBox.Show("Nhập hàng thành công");
                gridChiTietPN.DataSource = new List<Model.ChiTietPhieuNhap>();
                gridTimHang.DataSource = new List<MatHang>();
                txtThanhTien.Text = "";
                txtTimHang.Text = "";
                dtNgayNhap.Value = DateTime.Now;
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình nhập hàng");
            }
        }
    }
}
