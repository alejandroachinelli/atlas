using Atlas.Modules.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atlas.Modules.Identity.Persistence.Configurations;

public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.ToTable("refresh_tokens");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.TokenHash)
            .HasMaxLength(128)
            .IsRequired();

        builder.HasIndex(x => x.TokenHash)
            .IsUnique();

        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.ExpiresAt).IsRequired();

        builder.Property(x => x.CreatedByIp).HasMaxLength(64);
        builder.Property(x => x.CreatedByUserAgent).HasMaxLength(512);
        builder.Property(x => x.RevokedByIp).HasMaxLength(64);

        builder.Property(x => x.ReplacedByTokenHash).HasMaxLength(128);
    }
}
