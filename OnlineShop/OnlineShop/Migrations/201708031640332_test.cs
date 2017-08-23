namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "CategoryName", c => c.String());
            AddColumn("dbo.Order", "Comment", c => c.String());
            AddColumn("dbo.Order", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Category", "CategoryName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Product", "ProductName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Product", "NameImageFile", c => c.String(maxLength: 80));
            AlterColumn("dbo.Order", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Order", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Order", "Street", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Order", "City", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Order", "PostCode", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Order", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Order", "Email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Order", "Email", c => c.String());
            AlterColumn("dbo.Order", "Phone", c => c.String());
            AlterColumn("dbo.Order", "PostCode", c => c.String());
            AlterColumn("dbo.Order", "City", c => c.String());
            AlterColumn("dbo.Order", "Street", c => c.String());
            AlterColumn("dbo.Order", "Surname", c => c.String());
            AlterColumn("dbo.Order", "Name", c => c.String());
            AlterColumn("dbo.Product", "NameImageFile", c => c.String());
            AlterColumn("dbo.Product", "ProductName", c => c.String());
            AlterColumn("dbo.Category", "CategoryName", c => c.String());
            DropColumn("dbo.Order", "DateAdded");
            DropColumn("dbo.Order", "Comment");
            DropColumn("dbo.Product", "CategoryName");
        }
    }
}
