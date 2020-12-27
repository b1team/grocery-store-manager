﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("MatHang")]
    class MatHang
    {
        [Key]
        public int MaHang { get; set; }
        [Required]
        public int MaNCC { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Tên mặt hàng chỉ được tối đa 200 ký tự")]
        public string TenHang { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public bool DangKinhDoanh { get; set; }

        [ForeignKey(nameof(MaNCC))]
        public NhaCungCap NhaCungCap { get; set; }
    }
}
