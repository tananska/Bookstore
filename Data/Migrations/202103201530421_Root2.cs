namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Root2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropPrimaryKey("dbo.Products");
            CreateTable(
                "dbo.QuantitiesForProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Order_Id = c.Int(),
                        Product_Barcode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Products", t => t.Product_Barcode)
                .Index(t => t.Order_Id)
                .Index(t => t.Product_Barcode);
            
            AlterColumn("dbo.Products", "Barcode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Products", "Barcode");
            DropColumn("dbo.Products", "Order_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Order_Id", c => c.Int());
            DropForeignKey("dbo.QuantitiesForProducts", "Product_Barcode", "dbo.Products");
            DropForeignKey("dbo.QuantitiesForProducts", "Order_Id", "dbo.Orders");
            DropIndex("dbo.QuantitiesForProducts", new[] { "Product_Barcode" });
            DropIndex("dbo.QuantitiesForProducts", new[] { "Order_Id" });
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Barcode", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.QuantitiesForProducts");
            AddPrimaryKey("dbo.Products", "Barcode");
            CreateIndex("dbo.Products", "Order_Id");
            AddForeignKey("dbo.Products", "Order_Id", "dbo.Orders", "Id");
        }
    }
}
