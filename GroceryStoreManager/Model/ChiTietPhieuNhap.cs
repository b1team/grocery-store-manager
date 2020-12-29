using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap()
        {
            MaHang = "";
            TenHang = "";
            GiaNhap = 0;
            SoLuong = 0;
            ThanhTien = GiaNhap * SoLuong;
        }


        public ChiTietPhieuNhap( string MaHang, string TenHang, int DonGia, int SoLuong)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.GiaNhap = DonGia;
            this.SoLuong = SoLuong;
            this.ThanhTien = DonGia * SoLuong;
        }

        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int GiaNhap { get; set; }
        public int SoLuong { get;  set; }
        public int ThanhTien { get; set; }

        public static int ThanhToan(int DonGia, int SoLuong)
        {
            return DonGia * SoLuong;
        }
    }
}
