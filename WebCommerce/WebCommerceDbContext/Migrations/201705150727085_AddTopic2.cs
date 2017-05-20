namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTopic2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CATEGORY", "ColorTitleHex", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CATEGORY", "ColorTitleHex");
        }
    }
}
