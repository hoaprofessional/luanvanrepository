using Repository;
using System;

namespace Repository.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DcContext Init();
    }
}