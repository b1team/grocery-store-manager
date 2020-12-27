using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreManager.Model
{
    class NhaCungCap
    {
        public NhaCungCap()
        {
            STT = "";
            TenNhaCungCap = "";
            SoDienThoai = "";
            DiaChi = "";
        }

        public NhaCungCap(string stt, string TenNhaCungCap, string SoDienThoai, string DiaChi)
        {
            this.STT = stt;
            this.TenNhaCungCap = TenNhaCungCap;
            this.SoDienThoai = SoDienThoai;
            this.DiaChi = DiaChi;
        }

        public string STT { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}
