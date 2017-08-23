namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteShoeSize : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product", "ShoeSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "ShoeSize", c => c.Int(nullable: false));
        }
    }
}
