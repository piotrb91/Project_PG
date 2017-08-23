namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orders : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Order", name: "ApplicationUser_Id", newName: "UserId");
            RenameIndex(table: "dbo.Order", name: "IX_ApplicationUser_Id", newName: "IX_UserId");
            AddColumn("dbo.Order", "Address", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Order", "PostCode", c => c.String(nullable: false, maxLength: 6));
            DropColumn("dbo.Order", "Street");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order", "Street", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Order", "PostCode", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Order", "Address");
            RenameIndex(table: "dbo.Order", name: "IX_UserId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Order", name: "UserId", newName: "ApplicationUser_Id");
        }
    }
}
