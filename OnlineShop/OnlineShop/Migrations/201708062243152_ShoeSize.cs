namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoeSize : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ShoeSize", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ShoeSize");
        }
    }
}
