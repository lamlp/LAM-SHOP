using LAM_SHOP.Data.Infrastructure;
using LAM_SHOP.Model.Models;

namespace LAM_SHOP.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}