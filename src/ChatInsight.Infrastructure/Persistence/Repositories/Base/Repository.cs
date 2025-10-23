using ChatInsight.Domain.Entities;
using ChatInsight.Domain.Interfaces.IPersistences.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ChatInsight.Infrastructure.Persistence.Repositories.Base
{
    public class Repository<T, TKey> : IRepository<T, TKey> where T : BaseEntity<TKey>
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(TKey id)
            => await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => e.Id!.Equals(id));

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate)
            => await _dbSet.AsNoTracking().Where(predicate).ToListAsync();

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public void Update(T entity) => _dbSet.Update(entity);

        public void Delete(T entity)
        {
            entity.SoftDelete();
            _dbSet.Update(entity);
        }
    }
}
