namespace FoodTruckApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "CustomerUsername_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Reviews", new[] { "CustomerUsername_Id" });
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Item_Id = c.Int(),
                        Owner_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItems", t => t.Item_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Owner_Id)
                .Index(t => t.Item_Id)
                .Index(t => t.Owner_Id);
            
            DropColumn("dbo.FoodTrucks", "Category");
            DropColumn("dbo.Reviews", "CustomerUsername_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "CustomerUsername_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.FoodTrucks", "Category", c => c.String());
            DropForeignKey("dbo.ShoppingCarts", "Owner_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ShoppingCarts", "Item_Id", "dbo.MenuItems");
            DropIndex("dbo.ShoppingCarts", new[] { "Owner_Id" });
            DropIndex("dbo.ShoppingCarts", new[] { "Item_Id" });
            DropTable("dbo.ShoppingCarts");
            CreateIndex("dbo.Reviews", "CustomerUsername_Id");
            AddForeignKey("dbo.Reviews", "CustomerUsername_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
