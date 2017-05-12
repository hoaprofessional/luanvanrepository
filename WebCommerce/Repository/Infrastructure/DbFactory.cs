using Repository;
using WebCommerceDbContext;
namespace Repository.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WCDbContext dbContext;

        public WCDbContext Init()
        {
            return dbContext ?? (dbContext = new WCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}