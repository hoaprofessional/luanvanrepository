
using Microsoft.AspNet.Identity.EntityFramework;
using Model;
using System.Data.Entity;

namespace Repository
{
    public class DcContext : DbContext
    {
        public DcContext()
            : base("DcConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        #region Table in database

        //1_ThemBang: st2. Thêm DbSet<Lớp mới tạo ở bước 1> vào đây
        // Ví dụ ở đây là public DbSet<Demo> Demoes { set; get; }
        public DbSet<Demo> Demoes { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<CategoryRelationship> CategorieRelationships { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<SinhVien> SinhViens { set; get; }
        public DbSet<PhanSo> PhanSos { set; get; }
        public DbSet<LanguageCode> LanguageCodes { set; get; }

        #endregion
        public static DcContext Create()
        {
            return new DcContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().HasKey(i => new { i.Id }).ToTable("AspNetUsers");
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("AspNetUserLogins");
            builder.Entity<IdentityRole>().HasKey(i => new { i.Id }).ToTable("AspNetRoles");
            builder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("AspNetUserClaims");
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("AspNetUserRoles");

            //1_ThemBang: st3. Thêm đoạn code tương tự như sau để thêm store procedure

            builder.Entity<Demo>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertDemo", "dbo"))
                                                               .Update(u => u.HasName("UpdateDemo", "dbo"))
                                                               .Delete(u => u.HasName("DeleteDemo", "dbo"))
                );

            //st3. -- END

            builder.Entity<SinhVien>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertSinhVien", "dbo"))
                                                               .Update(u => u.HasName("UpdateSinhVien", "dbo"))
                                                               .Delete(u => u.HasName("DeleteSinhVien", "dbo"))
                );

            builder.Entity<PhanSo>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertPhanSo", "dbo"))
                                                               .Update(u => u.HasName("UpdatePhanSo", "dbo"))
                                                               .Delete(u => u.HasName("DeletePhanSo", "dbo"))
                );

            builder.Entity<Menu>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertMenu", "dbo"))
                                                               .Update(u => u.HasName("UpdateMenu", "dbo"))
                                                               .Delete(u => u.HasName("DeleteMenu", "dbo"))
                );

            builder.Entity<Category>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertCategory", "dbo"))
                                                               .Update(u => u.HasName("UpdateCategory", "dbo"))
                                                               .Delete(u => u.HasName("DeleteCategory", "dbo"))
                );

            builder.Entity<CategoryRelationship>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertCategoryRelationship", "dbo"))
                                                              .Update(u => u.HasName("UpdateCategoryRelationship", "dbo"))
                                                              .Delete(u => u.HasName("DeleteCategoryRelationship", "dbo"))
               );

        }

        //1_ThemBang: st4. vào package manager console gõ Add_Migration [Tên_migration tên gì cũng được miễn sao dễ hiểu]
        //tiếp tục gõ Update_Database
        //1_ThemBang: st5....................................................................................End 

        //2_CSCot: st2. vào package manager console gõ Add_Migration [Tên_migration tên gì cũng được miễn sao dễ hiểu]
        //tiếp tục gõ Update_Database
        //2_CSCot: st3....................................................................................End
    }
}