namespace DCContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuaNameThanhHoTen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SINHVIEN", "HoTen", c => c.String(maxLength: 500));
            DropColumn("dbo.SINHVIEN", "Name");
            AlterStoredProcedure(
                "dbo.InsertSinhVien",
                p => new
                    {
                        MSSV = p.String(maxLength: 12),
                        HoTen = p.String(maxLength: 500),
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
            
            AlterStoredProcedure(
                "dbo.UpdateSinhVien",
                p => new
                    {
                        Id = p.Int(),
                        MSSV = p.String(maxLength: 12),
                        HoTen = p.String(maxLength: 500),
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
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.SINHVIEN", "Name", c => c.String(maxLength: 500));
            DropColumn("dbo.SINHVIEN", "HoTen");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
