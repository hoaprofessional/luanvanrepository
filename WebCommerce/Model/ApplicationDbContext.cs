using Microsoft.AspNet.Identity.EntityFramework;

namespace Model
{
    public class ApplicationDbContext : 
        IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DcConnection")
        {
        }
    }
}