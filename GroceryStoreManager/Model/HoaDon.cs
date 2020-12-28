using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class HoaDon
    {
        public HoaDon()
        {
            MaHoaDon = "";
            TenHang = "";
            LoaiPhieu = "";
            NhanVienThuNgan = "";
            SoLuong = "";
            DonGia = "";
            ThanhTien = "";
        }

        public HoaDon(string MaHoaDon, string TenHang, string LoaiPhieu, string NhanVienThuNgan, string SoLuong, string DonGia, string ThanhTien)
        {
            this.MaHoaDon = MaHoaDon;
            this.TenHang = TenHang;
            this.LoaiPhieu = LoaiPhieu;
            this.NhanVienThuNgan = NhanVienThuNgan;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
        }

        public string MaHoaDon { get;  set; }
        public string TenHang { get; set; }
        public string LoaiPhieu { get;  set; }
        public string NhanVienThuNgan { get;  set; }
        public string SoLuong { get; set; }
        public string DonGia { get;  set; }
        public string ThanhTien { get;  set; }
    }
}
