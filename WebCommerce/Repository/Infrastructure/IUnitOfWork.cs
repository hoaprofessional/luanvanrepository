namespace Repository.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}