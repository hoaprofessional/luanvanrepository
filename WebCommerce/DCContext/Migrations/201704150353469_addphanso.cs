namespace DCContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addphanso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PHANSO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TuSo = c.Int(nullable: false),
                        MauSo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.InsertPhanSo",
                p => new
                    {
                        TuSo = p.Int(),
                        MauSo = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[PHANSO]([TuSo], [MauSo])
                      VALUES (@TuSo, @MauSo)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PHANSO]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PHANSO] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UpdatePhanSo",
                p => new
                    {
                        Id = p.Int(),
                        TuSo = p.Int(),
                        MauSo = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[PHANSO]
                      SET [TuSo] = @TuSo, [MauSo] = @MauSo
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeletePhanSo",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PHANSO]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeletePhanSo");
            DropStoredProcedure("dbo.UpdatePhanSo");
            DropStoredProcedure("dbo.InsertPhanSo");
            DropTable("dbo.PHANSO");
        }
    }
}
