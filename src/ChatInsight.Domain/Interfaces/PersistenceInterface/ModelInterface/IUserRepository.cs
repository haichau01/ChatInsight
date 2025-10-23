using ChatInsight.Domain.Entities.ModelEntities;
using ChatInsight.Domain.Interfaces.IPersistences.Generic;

namespace ChatInsight.Domain.Interfaces.PersistenceInterface.ModelInterface
{
    public interface IUserRepository : IRepository<UserEntity, Guid>
    {
    }
}
