namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTopic4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TOPIC", "LastPost", c => c.String());
            AddColumn("dbo.TOPIC", "LastPostTime", c => c.DateTime(nullable: false));
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
                        LastPost = p.String(),
                        LastPostTime = p.DateTime(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"INSERT [dbo].[TOPIC]([TopicName], [Content], [NoOfViews], [NoOfLikes], [NoOfReplies], [CatParentId], [LastPost], [LastPostTime], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Status])
                      VALUES (@TopicName, @Content, @NoOfViews, @NoOfLikes, @NoOfReplies, @CatParentId, @LastPost, @LastPostTime, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy, @Status)
                      
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
                        LastPost = p.String(),
                        LastPostTime = p.DateTime(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"UPDATE [dbo].[TOPIC]
                      SET [TopicName] = @TopicName, [Content] = @Content, [NoOfViews] = @NoOfViews, [NoOfLikes] = @NoOfLikes, [NoOfReplies] = @NoOfReplies, [CatParentId] = @CatParentId, [LastPost] = @LastPost, [LastPostTime] = @LastPostTime, [CreatedDate] = @CreatedDate, [CreatedBy] = @CreatedBy, [UpdatedDate] = @UpdatedDate, [UpdatedBy] = @UpdatedBy, [Status] = @Status
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.TOPIC", "LastPostTime");
            DropColumn("dbo.TOPIC", "LastPost");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
