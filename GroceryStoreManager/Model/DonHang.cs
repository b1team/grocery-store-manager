using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class DonHang
    {
        public DonHang()
        {
            MaPhieu = "";
            NgayBan = "";
            NvBanHang = "";
            TongTien = "";
        }

        public DonHang(string MaPhieu, string NgayBan, string NvBanHang, string TongTien)
        {
            this.MaPhieu = MaPhieu;
            this.NgayBan = NgayBan;
            this.NvBanHang = NvBanHang;
            this.TongTien = TongTien;
        }

        public string MaPhieu { get; set; }
        public string NgayBan { get; set; }
        public string NvBanHang { get; set; }
        public string TongTien { get; set; }
    }
}
