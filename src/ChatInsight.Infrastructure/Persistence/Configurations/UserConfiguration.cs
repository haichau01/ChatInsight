using ChatInsight.Domain.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatInsight.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            //builder.ToTable("users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(u => u.DisplayName)
                   //.HasColumnName("display_name")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(u => u.Email)
                   //.HasColumnName("email")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(u => u.CreatedAt)
                   //.HasColumnName("created_at")
                   //.HasDefaultValueSql("CURRENT_TIMESTAMP")
                   .IsRequired();

            builder.HasIndex(u => u.Email)
                   .IsUnique();
        }
    }
}
