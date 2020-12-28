using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class GiaoDich
    {
        public GiaoDich()
        {
            HoaDon = "";
            NguoiTao = "";
            LoaiPhieu = "";
            GiaTri = "";
        }

        public GiaoDich(string HoaDon, string NguoiTao, string LoaiPhieu, string GiaTri)
        {
            this.HoaDon = HoaDon;
            this.NguoiTao = NguoiTao;
            this.LoaiPhieu = LoaiPhieu;
            this.GiaTri = GiaTri;
        }

        public string HoaDon { get; set; }
        public string NguoiTao { get; }
        public string LoaiPhieu { get; set; }
        public string GiaTri { get; set; }
    }
}
