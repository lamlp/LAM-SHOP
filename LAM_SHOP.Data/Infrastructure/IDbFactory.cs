using System;

namespace LAM_SHOP.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        LAM_SHOPDbContext Init();
    }
}