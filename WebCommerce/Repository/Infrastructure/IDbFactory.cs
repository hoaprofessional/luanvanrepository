using Repository;
using System;
using WebCommerceDbContext;

namespace Repository.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WCDbContext Init();
    }
}