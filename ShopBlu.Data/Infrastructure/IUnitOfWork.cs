namespace ShopBlu.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}