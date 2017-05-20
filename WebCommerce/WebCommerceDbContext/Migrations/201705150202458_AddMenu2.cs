namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenu2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WEBMENU", "FaSymbol", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WEBMENU", "FaSymbol");
        }
    }
}
