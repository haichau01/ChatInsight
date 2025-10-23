using ChatInsight.Domain.Entities.ModelEntities;
using ChatInsight.Domain.Interfaces.PersistenceInterface.ModelInterface;
using ChatInsight.Infrastructure.Persistence.Repositories.Base;

namespace ChatInsight.Infrastructure.Persistence.Repositories
{
    class UserRepository : Repository<UserEntity, Guid>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }
    }
}
