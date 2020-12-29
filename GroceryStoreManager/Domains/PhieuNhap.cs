using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("PhieuNhap")]
    class PhieuNhap
    {
        [Key]
        public int MaPhieuNhap { get; set; }
        [Required]
        public int MaNCC { get; set; }
        [Required]
        public float ThanhTien { get; set; }
        [Required]
        public bool DaThanhToan { get; set; }
        public DateTime NgayTao { get; set; }

        [ForeignKey(nameof(MaNCC))]
        public NhaCungCap NhaCungCap { get; set; }
    }
}
