using ShopBlu.Data.Infrastructure;
using ShopBlu.Model.Models;

namespace ShopBlu.Data.Repositories
{
    public interface IProductRepository
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
