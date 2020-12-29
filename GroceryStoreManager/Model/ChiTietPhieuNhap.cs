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
            MaHang = 0;
            TenHang = "";
            GiaNhap = 0;
            SoLuong = 0;
            ThanhTien = GiaNhap * SoLuong;
        }


        public ChiTietPhieuNhap( int MaHang, string TenHang, float DonGia, int SoLuong)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.GiaNhap = DonGia;
            this.SoLuong = SoLuong;
            this.ThanhTien = DonGia * SoLuong;
        }

        public int MaHang { get; set; }
        public string TenHang { get; set; }
        public float GiaNhap { get; set; }
        public int SoLuong { get;  set; }
        public float ThanhTien { get; set; }

        public static float ThanhToan(int DonGia, int SoLuong)
        {
            return DonGia * SoLuong;
        }
    }
}
