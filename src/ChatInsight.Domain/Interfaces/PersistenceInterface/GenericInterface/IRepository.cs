using ChatInsight.Domain.Entities;
using System.Linq.Expressions;

namespace ChatInsight.Domain.Interfaces.IPersistences.Generic
{
    public interface IRepository<T, TKey> where T : BaseEntity<TKey>
    {
        Task<T?> GetByIdAsync(TKey id);
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
