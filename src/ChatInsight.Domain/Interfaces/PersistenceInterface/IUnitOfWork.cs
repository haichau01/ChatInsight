using ChatInsight.Domain.Interfaces.PersistenceInterface.ModelInterface;

namespace ChatInsight.Domain.Interfaces.IPersistences
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        public IUserRepository Users { get; }
        Task<int> SaveChangesAsync();
    }
}
