using System;

namespace ShopBlu.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopBluDbContext Init();
    }
}