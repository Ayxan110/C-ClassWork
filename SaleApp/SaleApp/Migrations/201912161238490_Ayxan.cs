namespace SaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ayxan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 30),
                        Price = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 30),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "ProductId", "dbo.Products");
            DropIndex("dbo.Photos", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.Photos");
        }
    }
}
