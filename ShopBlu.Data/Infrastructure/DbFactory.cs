namespace ShopBlu.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopBluDbContext dbContext;

        public ShopBluDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopBluDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}