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


        public ChiTietHoaDon( int MaHang, string TenHang, int SoLuong, float GiaBan)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.GiaBan = GiaBan;
            this.SoLuong = SoLuong;
            this.ThanhTien = (GiaBan * SoLuong);
        }

        public int MaHang { get; set; }
        public string TenHang { get; }
        public float GiaBan { get; set; }
        public int SoLuong { get;  set; }
        public float ThanhTien { get; set; }

        public static float ThanhToan(float GiaBan, int SoLuong)
        {
            return GiaBan * SoLuong;
        }
    }
}
