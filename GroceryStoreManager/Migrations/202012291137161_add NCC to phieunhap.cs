namespace GroceryStoreManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNCCtophieunhap : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuNhap", "MaNCC", c => c.Int(nullable: false));
            CreateIndex("dbo.PhieuNhap", "MaNCC");
            AddForeignKey("dbo.PhieuNhap", "MaNCC", "dbo.NhaCungCap", "MaNCC", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuNhap", "MaNCC", "dbo.NhaCungCap");
            DropIndex("dbo.PhieuNhap", new[] { "MaNCC" });
            DropColumn("dbo.PhieuNhap", "MaNCC");
        }
    }
}
