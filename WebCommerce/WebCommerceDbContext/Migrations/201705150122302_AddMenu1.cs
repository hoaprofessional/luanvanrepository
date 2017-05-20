namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenu1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WEBMENU",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuName = c.String(maxLength: 50),
                        MenuUrl = c.String(maxLength: 500),
                        MenuParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WEBMENU");
        }
    }
}
