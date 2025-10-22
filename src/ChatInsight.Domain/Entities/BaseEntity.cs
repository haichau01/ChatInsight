namespace ChatInsight.Domain.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; protected set; }

        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public string? CreatedBy { get; private set; }

        public DateTime? UpdatedAt { get; private set; }
        public string? UpdatedBy { get; private set; }

        public bool IsDeleted { get; private set; } = false;
        public void SoftDelete(string? userId = null)
        {
            IsDeleted = true;
            UpdatedAt = DateTime.UtcNow;
            UpdatedBy = userId;
        }
    }
    public abstract class BaseEntity : BaseEntity<Guid>
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
