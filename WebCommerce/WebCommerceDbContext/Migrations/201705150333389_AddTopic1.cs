namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTopic1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CATEGORY",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        CategoryName = c.String(),
                        Image = c.String(),
                        NoOfTopics = c.Int(nullable: false),
                        NoOfLikes = c.Int(nullable: false),
                        NoOfView = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.InsertTopic",
                p => new
                    {
                        TopicName = p.String(),
                        Content = p.String(),
                        NoOfViews = p.Int(),
                        NoOfLikes = p.Int(),
                        CatParentId = p.Int(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"INSERT [dbo].[TOPIC]([TopicName], [Content], [NoOfViews], [NoOfLikes], [CatParentId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Status])
                      VALUES (@TopicName, @Content, @NoOfViews, @NoOfLikes, @CatParentId, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy, @Status)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[TOPIC]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[TOPIC] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateTopic",
                p => new
                    {
                        Id = p.Int(),
                        TopicName = p.String(),
                        Content = p.String(),
                        NoOfViews = p.Int(),
                        NoOfLikes = p.Int(),
                        CatParentId = p.Int(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"UPDATE [dbo].[TOPIC]
                      SET [TopicName] = @TopicName, [Content] = @Content, [NoOfViews] = @NoOfViews, [NoOfLikes] = @NoOfLikes, [CatParentId] = @CatParentId, [CreatedDate] = @CreatedDate, [CreatedBy] = @CreatedBy, [UpdatedDate] = @UpdatedDate, [UpdatedBy] = @UpdatedBy, [Status] = @Status
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteTopic",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[TOPIC]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteTopic");
            DropStoredProcedure("dbo.UpdateTopic");
            DropStoredProcedure("dbo.InsertTopic");
            DropTable("dbo.CATEGORY");
        }
    }
}
