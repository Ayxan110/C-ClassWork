namespace SaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chngedPhoto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Photos", "Name", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Photos", "Name", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
