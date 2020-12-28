using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GroceryStoreManager.Domains
{
    class DatabaseContext: DbContext
    {
        public DatabaseContext() : base("name=DatabaseString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHD>()
                .HasKey(c => new { c.MaHD, c.MaHang });
            modelBuilder.Entity<ChiTietPN>()
               .HasKey(c => new { c.MaPhieuNhap, c.MaHang });
            Database.SetInitializer<DatabaseContext>(null);
        }
        public DbSet<Quyen> DsQuyen { get; set; }
        public DbSet<NguoiDung> DsNguoiDung { get; set; }
        public DbSet<NhaCungCap> DsNhaCungCap { get; set; }
        public DbSet<MatHang> DsMatHang { get; set; }
        public DbSet<HoaDon> DsHoaDon { get; set; }
        public DbSet<ChiTietHD> DsChiTietHD { get; set; }
        public DbSet<PhieuNhap> DsPhieuNhap { get; set; }
        public DbSet<ChiTietPN> DsChiTietPN { get; set; }
        
    }
}
