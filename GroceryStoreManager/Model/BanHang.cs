using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class BanHang
    {
        public BanHang()
        {
            MaHang = "";
            TenHang = "";
            DonGia = 0;
            SoLuong = 0;
            ThanhTien = DonGia * SoLuong;
        }


        public BanHang( string MaHang, string TenHang, int DonGia, int SoLuong)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.DonGia = DonGia;
            this.SoLuong = SoLuong;
            this.ThanhTien = DonGia * SoLuong;
        }

        public string MaHang { get; set; }
        public string TenHang { get; }
        public int DonGia { get; set; }
        public int SoLuong { get;  set; }
        public int ThanhTien { get; set; }

        public static int ThanhToan(int DonGia, int SoLuong)
        {
            return DonGia * SoLuong;
        }
    }
}
