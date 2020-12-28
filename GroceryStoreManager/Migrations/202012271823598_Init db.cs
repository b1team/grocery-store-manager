namespace GroceryStoreManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietHD",
                c => new
                    {
                        MaHD = c.Int(nullable: false),
                        MaHang = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Single(nullable: false),
                        ThanhTien = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaHD, t.MaHang })
                .ForeignKey("dbo.HoaDon", t => t.MaHD, cascadeDelete: true)
                .ForeignKey("dbo.MatHang", t => t.MaHang, cascadeDelete: true)
                .Index(t => t.MaHD)
                .Index(t => t.MaHang);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHD = c.Int(nullable: false, identity: true),
                        NgayTao = c.DateTime(nullable: false),
                        HanThanhToan = c.DateTime(nullable: false),
                        ThoiGianThanhToan = c.DateTime(nullable: false),
                        DaThanhToan = c.Boolean(nullable: false),
                        ThanhTien = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaHD);
            
            CreateTable(
                "dbo.MatHang",
                c => new
                    {
                        MaHang = c.Int(nullable: false, identity: true),
                        MaNCC = c.Int(nullable: false),
                        TenHang = c.String(nullable: false, maxLength: 200),
                        SoLuong = c.Int(nullable: false),
                        DangKinhDoanh = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaHang)
                .ForeignKey("dbo.NhaCungCap", t => t.MaNCC, cascadeDelete: true)
                .Index(t => t.MaNCC);
            
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        MaNCC = c.Int(nullable: false, identity: true),
                        TenNCC = c.String(nullable: false, maxLength: 200),
                        SDT = c.String(nullable: false),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.ChiTietPN",
                c => new
                    {
                        MaPhieuNhap = c.Int(nullable: false),
                        MaHang = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Single(nullable: false),
                        ThanhTien = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaPhieuNhap, t.MaHang })
                .ForeignKey("dbo.MatHang", t => t.MaHang, cascadeDelete: true)
                .ForeignKey("dbo.PhieuNhap", t => t.MaPhieuNhap, cascadeDelete: true)
                .Index(t => t.MaPhieuNhap)
                .Index(t => t.MaHang);
            
            CreateTable(
                "dbo.PhieuNhap",
                c => new
                    {
                        MaPhieuNhap = c.Int(nullable: false, identity: true),
                        ThanhTien = c.Single(nullable: false),
                        DaThanhToan = c.Boolean(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.NguoiDung",
                c => new
                    {
                        MaNguoiDung = c.Int(nullable: false, identity: true),
                        MaQuyen = c.Int(nullable: false),
                        TenDangNhap = c.String(nullable: false, maxLength: 200),
                        MatKhau = c.String(nullable: false),
                        TenNguoiDung = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaNguoiDung)
                .ForeignKey("dbo.Quyen", t => t.MaQuyen, cascadeDelete: true)
                .Index(t => t.MaQuyen);
            
            CreateTable(
                "dbo.Quyen",
                c => new
                    {
                        MaQuyen = c.Int(nullable: false, identity: true),
                        Cap = c.Int(nullable: false),
                        TenQuyen = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.MaQuyen);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NguoiDung", "MaQuyen", "dbo.Quyen");
            DropForeignKey("dbo.ChiTietPN", "MaPhieuNhap", "dbo.PhieuNhap");
            DropForeignKey("dbo.ChiTietPN", "MaHang", "dbo.MatHang");
            DropForeignKey("dbo.ChiTietHD", "MaHang", "dbo.MatHang");
            DropForeignKey("dbo.MatHang", "MaNCC", "dbo.NhaCungCap");
            DropForeignKey("dbo.ChiTietHD", "MaHD", "dbo.HoaDon");
            DropIndex("dbo.NguoiDung", new[] { "MaQuyen" });
            DropIndex("dbo.ChiTietPN", new[] { "MaHang" });
            DropIndex("dbo.ChiTietPN", new[] { "MaPhieuNhap" });
            DropIndex("dbo.MatHang", new[] { "MaNCC" });
            DropIndex("dbo.ChiTietHD", new[] { "MaHang" });
            DropIndex("dbo.ChiTietHD", new[] { "MaHD" });
            DropTable("dbo.Quyen");
            DropTable("dbo.NguoiDung");
            DropTable("dbo.PhieuNhap");
            DropTable("dbo.ChiTietPN");
            DropTable("dbo.NhaCungCap");
            DropTable("dbo.MatHang");
            DropTable("dbo.HoaDon");
            DropTable("dbo.ChiTietHD");
        }
    }
}
