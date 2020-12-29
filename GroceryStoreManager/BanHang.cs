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
using System.Data.Entity;

namespace GroceryStoreManager
{
    public partial class BanHang : MetroFramework.Forms.MetroForm
    {
        private DatabaseContext session;
        private NguoiDung thuNgan;
        private Quyen quyen;
        private List<Model.ChiTietHoaDon> SelectedItems = new List<Model.ChiTietHoaDon>();
        private List<Model.ChiTietHoaDon> Items = new List<Model.ChiTietHoaDon>();


        internal NguoiDung ThuNgan { get => thuNgan; set => thuNgan = value; }
        internal Quyen Quyen { get => quyen; set => quyen = value; }

        public BanHang()
        {
            InitializeComponent();
            session = new DatabaseContext();
        }

        public void HoaDon()
        {
            
            int total = GridBanHang1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[4].Value));
            int TongTienHang =total;
            int KhachCanTra = (int)(TongTienHang);

            int KhachThanhToan = Convert.ToInt32(txtKhachThanhToan.Text.Trim());
            int TienThuaTraKhach = KhachThanhToan - KhachCanTra;

            lbTongTienHang.Text = TongTienHang.ToString();
            lbKhachCanTra.Text = KhachCanTra.ToString();
            lbTienThuaTraKhach.Text = TienThuaTraKhach.ToString();

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            lbNhanVienThuNgan.Text = thuNgan.TenNguoiDung;
        }

        private void txtKhachThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void handle_cellclicks(object sender, DataGridViewCellEventArgs e)
        { 
            DataGridViewRow row = GridBanHang2.Rows[e.RowIndex];
            int mahang = Convert.ToInt32(row.Cells[0].Value);
            string tenhang = Convert.ToString(row.Cells[1].Value);
            int soluong = Convert.ToInt32(row.Cells[2].Value);
            int giaban = Convert.ToInt32(row.Cells[3].Value);
            var item = new Model.ChiTietHoaDon(mahang, tenhang, 1, giaban);

            int rows = GridBanHang1.Rows.Count;
            var existed = false;
            for(int i=0; i<rows; i++)
            {
                DataGridViewRow row1 = GridBanHang1.Rows[i];
                if (Convert.ToInt32(row1.Cells[0].Value) == item.MaHang)
                {
                    row1.Cells[2].Value = (int)row1.Cells[2].Value + 1;
                    row1.Cells[4].Value = Model.ChiTietHoaDon.ThanhToan((int)row1.Cells[3].Value, (int)row1.Cells[2].Value);
                    existed = true;
                    break;
                }
            }
            if (!existed)
            {
                SelectedItems.Add(item);
                
            }

            GridBanHang1.DataSource = new List<Model.ChiTietHoaDon>();
            GridBanHang1.DataSource = SelectedItems;
        }



        private void GridBanHang1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridBanHang1.Rows[e.RowIndex];
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            session.DsMatHang.Load();
            var data = session.DsMatHang.Local.ToBindingList().Where(hang => hang.DangKinhDoanh.Equals(true) && hang.TenHang.ToLower().Contains(txtTimKiem.Text));
            GridBanHang2.DataSource = data.ToList();
        }


        private void TinhLaiTongTien(object sender, DataGridViewCellEventArgs e)
        {
            int total = GridBanHang1.Rows.Cast<DataGridViewRow>()
                 .Sum(t => Convert.ToInt32(t.Cells[4].Value));
            int TongTienHang = total;
            lbTongTienHang.Text = TongTienHang.ToString();
        }

        private void GridBanHang1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int total = GridBanHang1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[4].Value));
            int TongTienHang = total;
            lbTongTienHang.Text = TongTienHang.ToString();
        }
    }
}
