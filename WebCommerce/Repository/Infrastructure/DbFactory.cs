using Repository;
namespace Repository.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DcContext dbContext;

        public DcContext Init()
        {
            return dbContext ?? (dbContext = new DcContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}