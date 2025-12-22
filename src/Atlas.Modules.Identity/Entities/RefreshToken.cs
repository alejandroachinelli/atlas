namespace Atlas.Modules.Identity.Entities;

public class RefreshToken
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid UserId { get; set; }
    public User User { get; set; } = default!;

    // Hash del refresh token real (NO guardamos el token plano)
    public string TokenHash { get; set; } = default!;

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset ExpiresAt { get; set; }

    public DateTimeOffset? RevokedAt { get; set; }

    // Rotación: cuando se usa, se reemplaza por otro
    public string? ReplacedByTokenHash { get; set; }

    // Auditoría / seguridad
    public string? CreatedByIp { get; set; }
    public string? CreatedByUserAgent { get; set; }
    public string? RevokedByIp { get; set; }

    public bool IsExpired => DateTimeOffset.UtcNow >= ExpiresAt;
    public bool IsRevoked => RevokedAt != null;
    public bool IsActive => !IsExpired && !IsRevoked;
}
