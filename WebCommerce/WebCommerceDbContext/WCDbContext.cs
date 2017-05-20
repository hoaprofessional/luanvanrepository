using Microsoft.AspNet.Identity.EntityFramework;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerceDbContext
{
    public class WCDbContext : DbContext
    {
        public WCDbContext()
            : base("DbConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        #region Table in database

        //1_ThemBang: st2. Thêm DbSet<Lớp mới tạo ở bước 1> vào đây
        // Ví dụ ở đây là public DbSet<LanguageCode> LanguageCodes { set; get; }
        public DbSet<LanguageCode> LanguageCodes { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<Topic> Topics { set; get; }
        public DbSet<Category> Categories { set; get; }

        #endregion
        public static WCDbContext Create()
        {
            return new WCDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().HasKey(i => new { i.Id }).ToTable("AspNetUsers");
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("AspNetUserLogins");
            builder.Entity<IdentityRole>().HasKey(i => new { i.Id }).ToTable("AspNetRoles");
            builder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("AspNetUserClaims");
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("AspNetUserRoles");

           // 1_ThemBang: st3. Thêm đoạn code tương tự như sau để thêm store procedure
            builder.Entity<Topic>().MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertTopic", "dbo"))
                                                   .Update(u => u.HasName("UpdateTopic", "dbo"))
                                                   .Delete(u => u.HasName("DeleteTopic", "dbo"))
    );


            //st3. -- END



        }

        //1_ThemBang: st4. vào package manager console gõ Add_Migration [Tên_migration tên gì cũng được miễn sao dễ hiểu]
        //tiếp tục gõ Update_Database
        //1_ThemBang: st5....................................................................................End 

        //2_CSCot: st2. vào package manager console gõ Add_Migration [Tên_migration tên gì cũng được miễn sao dễ hiểu]
        //tiếp tục gõ Update_Database
        //2_CSCot: st3....................................................................................End
    }
}
