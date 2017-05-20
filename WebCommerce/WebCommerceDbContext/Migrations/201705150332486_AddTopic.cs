namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTopic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TOPIC",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TopicName = c.String(),
                        Content = c.String(),
                        NoOfViews = c.Int(nullable: false),
                        NoOfLikes = c.Int(nullable: false),
                        CatParentId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.CATEGORY");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CATEGORY",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        CategoryName = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.TOPIC");
        }
    }
}
