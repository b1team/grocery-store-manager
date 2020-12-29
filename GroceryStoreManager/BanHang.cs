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

        internal NguoiDung ThuNgan { get => thuNgan; set => thuNgan = value; }
        internal Quyen Quyen { get => quyen; set => quyen = value; }

        public BanHang()
        {
            InitializeComponent();
            session = new DatabaseContext();
        }

        public void GetDefaultValue()
        {
            float total = GridBanHang1.Rows.Cast<DataGridViewRow>()
                 .Sum(t => (float)(t.Cells[4].Value));
            float TongTienHang = total;

            float KhachThanhToan = 0;
            txtKhachThanhToan.Text = KhachThanhToan.ToString();

            btnThanhToan.Enabled = TongTienHang > 0;
            lbTongTienHang.Text = TongTienHang.ToString();

            float KhachCanTra = TongTienHang > 0 ? TongTienHang : 0;
            lbKhachCanTra.Text = KhachCanTra.ToString();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            GetDefaultValue();
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
            float giaban = (float)Convert.ToDouble(row.Cells[3].Value);
            var item = new Model.ChiTietHoaDon(mahang, tenhang, 1, giaban);

            int rows = GridBanHang1.Rows.Count;

            var existed = false;
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row1 = GridBanHang1.Rows[i];
                if (Convert.ToInt32(row1.Cells[0].Value) == item.MaHang)
                {
                    row1.Cells[2].Value = (int)row1.Cells[2].Value + 1;
                    row1.Cells[4].Value = Model.ChiTietHoaDon.ThanhToan((float)row1.Cells[3].Value, (int)row1.Cells[2].Value);
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


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            session.DsMatHang.Load();
            var data = session.DsMatHang.Local.ToBindingList().Where(hang => hang.DangKinhDoanh.Equals(true) && hang.TenHang.ToLower().Contains(txtTimKiem.Text));
            GridBanHang2.DataSource = data.ToList();
        }


        private void TinhLaiTongTien(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridBanHang2.Rows[e.RowIndex];
            int mahang = Convert.ToInt32(row.Cells[0].Value);
            var TongSoLuongHang = session.DsMatHang.Where(mathang => mathang.MaHang == mahang).Select(mathang => mathang.SoLuong).First();
            int rows = GridBanHang1.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row1 = GridBanHang1.Rows[i];
                int soluong = Convert.ToInt32(row1.Cells[2].Value);
                if (soluong > Convert.ToInt32(TongSoLuongHang))
                    row1.Cells[2].Value = Convert.ToInt32(TongSoLuongHang);
                else if(soluong < 0)
                    row1.Cells[2].Value = 0;

                row1.Cells[4].Value = Model.ChiTietHoaDon.ThanhToan((float)Convert.ToDouble(row1.Cells[3].Value), Convert.ToInt32(row1.Cells[2].Value));
                break;
            }
            GetDefaultValue();
        }

        private void GridBanHang1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GetDefaultValue();
        }

        private void txtKhachThanhToan_TextChanged(object sender, EventArgs e)

        {
            try
            {
                lbTienThuaTraKhach.Text = "";
                float KhachCanTra = (float)Convert.ToDouble(lbKhachCanTra.Text.Trim());
                float KhachThanhToan = (float)Convert.ToDouble(txtKhachThanhToan.Text.Trim());
                float TienThuaTraKhach = KhachThanhToan - KhachCanTra;
                lbTienThuaTraKhach.Text = TienThuaTraKhach.ToString();
            }
            catch (Exception)
            {
                //
            }
        }

        private void ThanhToan()
        {
            DateTime NgayTao = DateTime.Parse(datetime.Value.Date.ToString().Trim());
            DateTime HanThanhToan = NgayTao;
            DateTime ThoiGianThanhToan = DateTime.Parse(datetime.Value.TimeOfDay.ToString());
            bool DaThanhToan = true;
            float TongTienHang = (float)Convert.ToDouble(lbTongTienHang.Text.Trim());
            HoaDon hd = new HoaDon()
            {
                NgayTao = NgayTao,
                HanThanhToan = HanThanhToan,
                ThoiGianThanhToan = ThoiGianThanhToan,
                DaThanhToan = DaThanhToan,
                ThanhTien = TongTienHang
            };

            foreach (var item in SelectedItems)
            {
                var hang = session.DsMatHang.Find(item.MaHang);
                hang.SoLuong = hang.SoLuong - item.SoLuong;
                ChiTietHD chitiethd = new ChiTietHD()
                {
                    SoLuong = item.SoLuong,
                    DonGia = item.GiaBan,
                    ThanhTien = item.ThanhTien
                };
                chitiethd.MatHang = hang;
                chitiethd.HoaDon = hd;
                session.DsChiTietHD.Add(chitiethd);
            }
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(lbTienThuaTraKhach.Text) >= 0)
                {
                    try
                    {
                        ThanhToan();
                        session.SaveChanges();
                        MessageBox.Show("Thanh Toán Thành Công!");
                        GridBanHang1.DataSource = null;
                        GridBanHang1.Refresh();
                        GetDefaultValue();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình thanh toán!!!");
                    }
                }
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
