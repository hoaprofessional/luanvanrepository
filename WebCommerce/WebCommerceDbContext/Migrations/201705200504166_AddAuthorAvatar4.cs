namespace WebCommerceDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorAvatar4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Bonus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Bonus");
        }
    }
}
