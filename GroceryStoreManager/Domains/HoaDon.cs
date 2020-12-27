using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("HoaDon")]
    class HoaDon
    {
        [Key]
        public int MaHD { get; set; }
        [Required]
        public DateTime NgayTao { get; set; }
        [Required]
        public DateTime HanThanhToan { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        [Required]
        public bool DaThanhToan { get; set; }
        [Required]
        public float ThanhTien { get; set; }

    }
}
