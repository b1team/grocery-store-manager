namespace GroceryStoreManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedgiabantoMaHang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MatHang", "GiaBan", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MatHang", "GiaBan");
        }
    }
}
