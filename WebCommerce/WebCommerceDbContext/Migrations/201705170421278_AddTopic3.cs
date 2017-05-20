namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTopic3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TOPIC", "NoOfReplies", c => c.Int(nullable: false));
            AlterStoredProcedure(
                "dbo.InsertTopic",
                p => new
                    {
                        TopicName = p.String(),
                        Content = p.String(),
                        NoOfViews = p.Int(),
                        NoOfLikes = p.Int(),
                        NoOfReplies = p.Int(),
                        CatParentId = p.Int(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"INSERT [dbo].[TOPIC]([TopicName], [Content], [NoOfViews], [NoOfLikes], [NoOfReplies], [CatParentId], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Status])
                      VALUES (@TopicName, @Content, @NoOfViews, @NoOfLikes, @NoOfReplies, @CatParentId, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy, @Status)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[TOPIC]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[TOPIC] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.UpdateTopic",
                p => new
                    {
                        Id = p.Int(),
                        TopicName = p.String(),
                        Content = p.String(),
                        NoOfViews = p.Int(),
                        NoOfLikes = p.Int(),
                        NoOfReplies = p.Int(),
                        CatParentId = p.Int(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"UPDATE [dbo].[TOPIC]
                      SET [TopicName] = @TopicName, [Content] = @Content, [NoOfViews] = @NoOfViews, [NoOfLikes] = @NoOfLikes, [NoOfReplies] = @NoOfReplies, [CatParentId] = @CatParentId, [CreatedDate] = @CreatedDate, [CreatedBy] = @CreatedBy, [UpdatedDate] = @UpdatedDate, [UpdatedBy] = @UpdatedBy, [Status] = @Status
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.TOPIC", "NoOfReplies");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
