using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class Hang
    {
        public Hang()
        {
            MaHang = "";
            TenHang = "";
            SoLuong = 0;
            NhaCungCap = "";
            GiaBan = 0;
            ThanhTien = GiaBan * SoLuong;
        }

        public Hang(string MaHang, string TenHang, int SoLuong, string NhaCungCap, int GiaBan)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.SoLuong = SoLuong;
            this.NhaCungCap = NhaCungCap;
            this.GiaBan = GiaBan;
            this.ThanhTien = SoLuong * GiaBan;
        }

        public string MaHang { get; set; }
        public string TenHang { get; }
        public int SoLuong { get; set; }
        public string NhaCungCap { get; set; }
        public int GiaBan { get; set; }
        public int ThanhTien { get; set; }
    }
}
