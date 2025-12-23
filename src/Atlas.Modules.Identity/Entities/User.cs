namespace Atlas.Modules.Identity.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Email { get; set; } = default!;
    public string EmailNormalized { get; set; } = default!;

    // Guardamos hash, NUNCA password
    public string PasswordHash { get; set; } = default!;

    public bool IsActive { get; set; } = true;
    public bool IsLocked { get; set; } = false;

    // Invalida sesiones cuando cambia algo sensible
    public string SecurityStamp { get; set; } = Guid.NewGuid().ToString("N");

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;

    // Navegación
    public List<RefreshToken> RefreshTokens { get; set; } = new();
}

