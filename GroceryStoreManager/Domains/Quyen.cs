using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreManager.Domains
{
    [Table("Quyen")]
    class Quyen
    {
        [Key]
        public int MaQuyen { get; set; }
        [Required]
        public int Cap { get; set; }
        [MaxLength(100, ErrorMessage = "Tên quyền chỉ được phép có 100 ký tự.")]
        public string TenQuyen { get; set; }
    }
}