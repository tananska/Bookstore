namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Root1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Barcode", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "Barcode");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Barcode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Products", "Barcode");
        }
    }
}
