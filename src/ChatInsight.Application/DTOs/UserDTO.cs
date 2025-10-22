namespace ChatInsight.Application.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; init; }
        public string DisplayName { get; init; } = default!;
        public string Email { get; init; } = default!;
        public DateTime CreatedAt { get; init; }

        // Có thể thêm field mở rộng
        public int TotalMessages { get; init; }

        // Mapping helper (tuỳ bạn dùng Mapster/AutoMapper)
        public static UserDTO FromEntity(Domain.Entities.ModelEntities.UserEntity user)
            => new()
            {
                Id = user.Id,
                DisplayName = user.DisplayName,
                Email = user.Email,
                CreatedAt = user.CreatedAt,
            };
    }
}
