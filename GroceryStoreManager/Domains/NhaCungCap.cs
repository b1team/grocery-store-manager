using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("NhaCungCap")]
    class NhaCungCap
    {
        [Key]
        public int MaNCC { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Tên nhà cung cấp chỉ được phép tôi đa 200 ký tự")]
        public string TenNCC { get; set; }
        [Required]
        public string SDT { get; set; }
        public string DiaChi { get; set; }
    }
}
