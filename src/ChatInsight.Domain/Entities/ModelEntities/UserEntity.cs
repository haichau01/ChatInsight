namespace ChatInsight.Domain.Entities.ModelEntities
{
    public class UserEntity : BaseEntity
    {
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string? JobTitle { get; private set; }

        private UserEntity() { }
    }
}
