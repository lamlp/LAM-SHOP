namespace LAM_SHOP.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private LAM_SHOPDbContext dbContext;

        public LAM_SHOPDbContext Init()
        {
            return dbContext ?? (dbContext = new LAM_SHOPDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}