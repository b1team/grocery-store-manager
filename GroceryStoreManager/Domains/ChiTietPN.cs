using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("ChiTietPN")]
    class ChiTietPN
    {
        public int MaPhieuNhap { get; set; }
        public int MaHang { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public float DonGia { get; set; }
        [Required]
        public float ThanhTien { get; set; }

        [ForeignKey(nameof(MaHang))]
        public MatHang MatHang { get; set; }
        [ForeignKey(nameof(MaPhieuNhap))]
        public PhieuNhap PhieuNhap { get; set; }
    }
}
