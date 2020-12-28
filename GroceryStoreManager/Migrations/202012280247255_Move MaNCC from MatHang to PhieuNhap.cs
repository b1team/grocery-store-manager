namespace GroceryStoreManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoveMaNCCfromMatHangtoPhieuNhap : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MatHang", "MaNCC", "dbo.NhaCungCap");
            DropIndex("dbo.MatHang", new[] { "MaNCC" });
            AddColumn("dbo.PhieuNhap", "MaNCC", c => c.Int(nullable: false));
            CreateIndex("dbo.PhieuNhap", "MaNCC");
            AddForeignKey("dbo.PhieuNhap", "MaNCC", "dbo.NhaCungCap", "MaNCC", cascadeDelete: true);
            DropColumn("dbo.MatHang", "MaNCC");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MatHang", "MaNCC", c => c.Int(nullable: false));
            DropForeignKey("dbo.PhieuNhap", "MaNCC", "dbo.NhaCungCap");
            DropIndex("dbo.PhieuNhap", new[] { "MaNCC" });
            DropColumn("dbo.PhieuNhap", "MaNCC");
            CreateIndex("dbo.MatHang", "MaNCC");
            AddForeignKey("dbo.MatHang", "MaNCC", "dbo.NhaCungCap", "MaNCC", cascadeDelete: true);
        }
    }
}
