using ShopBlu.Data.Infrastructure;
using ShopBlu.Model.Models;

namespace ShopBlu.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
