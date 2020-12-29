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
    public partial class BanHang : MetroFramework.Forms.MetroForm
    {
        private NguoiDung thuNgan;
        private Quyen quyen;
        private List<Model.ChiTietPhieuNhap> SelectedItems = new List<Model.ChiTietPhieuNhap>();
        private List<Model.ChiTietPhieuNhap> Items = new List<Model.ChiTietPhieuNhap>();

        internal NguoiDung ThuNgan { get => thuNgan; set => thuNgan = value; }
        internal Quyen Quyen { get => quyen; set => quyen = value; }

        public BanHang()
        {
            InitializeComponent();
        }

        public void HoaDon()
        {
            lbNhanVienThuNgan.Text = "tungnt";
            int TongTienHang = 140000;
            Double GiamGia = 10;
            int KhachCanTra = (int)(TongTienHang * ((100 - GiamGia) / 100));
            txtKhachThanhToan.Text = "150000";

            int KhachThanhToan = Int32.Parse(txtKhachThanhToan.Text);
            int TienThuaTraKhach = KhachThanhToan - KhachCanTra;

            lbTongTienHang.Text = TongTienHang.ToString();
            lbGiamGia.Text = GiamGia.ToString();
            lbKhachCanTra.Text = KhachCanTra.ToString();
            lbTienThuaTraKhach.Text = TienThuaTraKhach.ToString();

        }

        private void BanHang_Load(object sender, EventArgs e)
        {

            List<Model.Hang> data = new List<Model.Hang>();
            data.Add(new Model.Hang("1", "hang 1", 2, "nha cung cap 1", 1200));
            data.Add(new Model.Hang("2", "hang 2", 3, "nha cung cap 2", 1300));
            data.Add(new Model.Hang("3", "hang 3", 4, "nha cung cap 3", 1400));
            data.Add(new Model.Hang("4", "hang 4", 5, "nha cung cap 4", 1500));
            GridBanHang2.DataSource = new List<Model.ChiTietPhieuNhap>();
            GridBanHang2.DataSource = data;
            HoaDon();
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


        private void GridBanHang2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            DataGridViewRow row = GridBanHang2.Rows[e.RowIndex];
            var item = new Model.ChiTietPhieuNhap(Convert.ToString(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToInt32(row.Cells[2].Value), 1);
            
            int rows = GridBanHang1.Rows.Count;
            var existed = false;
            for(int i=0; i<rows; i++)
            {
                DataGridViewRow row1 = GridBanHang1.Rows[i];
                if (row1.Cells["MaHang"].Value.ToString() == item.MaHang)
                {
                    row1.Cells["SoLuong"].Value = (int)row1.Cells["SoLuong"].Value + 1;
                    row1.Cells["ThanhTien"].Value = Model.ChiTietPhieuNhap.ThanhToan((int)row1.Cells["DonGia"].Value, (int)row1.Cells["SoLuong"].Value);
                    existed = true;
                    break;
                }
            }
            if (!existed)
            {
                SelectedItems.Add(item);
                
            }
            GridBanHang1.DataSource = new List<Model.ChiTietPhieuNhap>();
            GridBanHang1.DataSource = SelectedItems;
        }



        private void GridBanHang1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridBanHang1.Rows[e.RowIndex];
            
        }

       
    }
}
