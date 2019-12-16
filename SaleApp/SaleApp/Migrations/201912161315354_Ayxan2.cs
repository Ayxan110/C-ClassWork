namespace SaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ayxan2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "VerificationCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "VerificationCode");
        }
    }
}
