using ShopBlu.Data.Infrastructure;
using ShopBlu.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopBlu.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategory.Where(x => x.Alias == alias);
        }
    }
}
