namespace GroceryStoreManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Uniqueusername : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhieuNhap", "MaNCC", "dbo.NhaCungCap");
            DropIndex("dbo.PhieuNhap", new[] { "MaNCC" });
            CreateIndex("dbo.NguoiDung", "TenDangNhap", unique: true);
            DropColumn("dbo.PhieuNhap", "MaNCC");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhieuNhap", "MaNCC", c => c.Int(nullable: false));
            DropIndex("dbo.NguoiDung", new[] { "TenDangNhap" });
            CreateIndex("dbo.PhieuNhap", "MaNCC");
            AddForeignKey("dbo.PhieuNhap", "MaNCC", "dbo.NhaCungCap", "MaNCC", cascadeDelete: true);
        }
    }
}
