namespace DCContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XoaSinhVien : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SINHVIEN");
            DropStoredProcedure("dbo.InsertSinhVien");
            DropStoredProcedure("dbo.UpdateSinhVien");
            DropStoredProcedure("dbo.DeleteSinhVien");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SINHVIEN",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MSSV = c.String(maxLength: 12),
                        HoTen = c.String(maxLength: 500),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
