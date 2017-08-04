namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Category", "CategoryForMen");
            DropColumn("dbo.Category", "CategoryForWomen");
            DropColumn("dbo.Product", "CategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "CategoryName", c => c.String());
            AddColumn("dbo.Category", "CategoryForWomen", c => c.Boolean(nullable: false));
            AddColumn("dbo.Category", "CategoryForMen", c => c.Boolean(nullable: false));
        }
    }
}
