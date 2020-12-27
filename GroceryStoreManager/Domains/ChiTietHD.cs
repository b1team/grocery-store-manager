using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("ChiTietHD")]
    class ChiTietHD
    {
        public int MaHD { get; set; }
        public int MaHang { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public float DonGia { get; set; }
        [Required]
        public float ThanhTien { get; set; }

        [ForeignKey(nameof(MaHang))]
        public MatHang MatHang { get; set; }
        [ForeignKey(nameof(MaHD))]
        public HoaDon HoaDon { get; set; }
    }
}
