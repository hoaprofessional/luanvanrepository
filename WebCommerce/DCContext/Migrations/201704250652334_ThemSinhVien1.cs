namespace DCContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemSinhVien1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SINHVIEN",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MSSV = c.String(),
                        HoTen = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.InsertSinhVien",
                p => new
                    {
                        MSSV = p.String(),
                        HoTen = p.String(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"INSERT [dbo].[SINHVIEN]([MSSV], [HoTen], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy], [Status])
                      VALUES (@MSSV, @HoTen, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy, @Status)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[SINHVIEN]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[SINHVIEN] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateSinhVien",
                p => new
                    {
                        Id = p.Int(),
                        MSSV = p.String(),
                        HoTen = p.String(),
                        CreatedDate = p.DateTime(),
                        CreatedBy = p.String(maxLength: 256),
                        UpdatedDate = p.DateTime(),
                        UpdatedBy = p.String(maxLength: 256),
                        Status = p.Boolean(),
                    },
                body:
                    @"UPDATE [dbo].[SINHVIEN]
                      SET [MSSV] = @MSSV, [HoTen] = @HoTen, [CreatedDate] = @CreatedDate, [CreatedBy] = @CreatedBy, [UpdatedDate] = @UpdatedDate, [UpdatedBy] = @UpdatedBy, [Status] = @Status
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteSinhVien",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[SINHVIEN]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteSinhVien");
            DropStoredProcedure("dbo.UpdateSinhVien");
            DropStoredProcedure("dbo.InsertSinhVien");
            DropTable("dbo.SINHVIEN");
        }
    }
}
