using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class NhapHang
    {
        public NhapHang()
        {
            MaPhieu = "";
            TenHang = "";
            NhaCungCap = "";
            NhaSanXuat = "";
            SoLuong = "";
            GiaNhap = "";
            TongTien = "";
        }

        public NhapHang(string MaPhieu, string TenHang, string NhaCungCap, string NhanSanXuat, string SoLuong, string GiaNhap, string TongTien)
        {
            this.MaPhieu = MaPhieu;
            this.TenHang = TenHang;
            this.NhaCungCap = NhaCungCap;
            this.NhaSanXuat = NhanSanXuat;
            this.SoLuong = SoLuong;
            this.GiaNhap = GiaNhap;
            this.TongTien = TongTien;
        }

        public string MaPhieu { get; set; }
        public string TenHang { get; set; }
        public string SoLuong { get; set; }
        public string NhaCungCap { get; set; }
        public string NhaSanXuat { get; set; }
        public string GiaNhap { get; set; }
        public string TongTien { get; set; }
    }
}
