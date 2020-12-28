using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("NguoiDung")]
    class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }
        [Required]
        public int MaQuyen { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Tên đăng nhập chỉ được phép tối đa 200 ký tự")]
        [MinLength(3, ErrorMessage = "Tên đăng nhập phải có ít nhất 3 ký tự.")]
        [Index(IsUnique = true)]
        public string TenDangNhap { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        public string MatKhau { get; set; }
        public string TenNguoiDung { get; set; }
        public DateTime NgayTao { get; set; }

        [ForeignKey(nameof(MaQuyen))]
        public Quyen Quyen { get; set; }
    }
}
