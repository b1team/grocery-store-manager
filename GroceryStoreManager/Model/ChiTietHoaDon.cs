using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class ChiTietHoaDon
    {
        public ChiTietHoaDon()
        {
            MaHang = 0;
            TenHang = "";
            SoLuong = 0;
            GiaBan = 0;
            ThanhTien = GiaBan * SoLuong;
        }


        public ChiTietHoaDon( int MaHang, string TenHang, int SoLuong, int GiaBan)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.GiaBan = GiaBan;
            this.SoLuong = SoLuong;
            this.ThanhTien = GiaBan * SoLuong;
        }

        public int MaHang { get; set; }
        public string TenHang { get; }
        public int GiaBan { get; set; }
        public int SoLuong { get;  set; }
        public int ThanhTien { get; set; }

        public static int ThanhToan(int GiaBan, int SoLuong)
        {
            return GiaBan * SoLuong;
        }
    }
}
