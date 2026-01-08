using Atlas.Modules.Identity.DTOs;

namespace Atlas.Modules.Identity.Interfaces.Services;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(RegisterRequest request, string? ip, string? userAgent, CancellationToken ct);
    Task<AuthResponse> LoginAsync(LoginRequest request, string? ip, string? userAgent, CancellationToken ct);
    Task<AuthResponse> RefreshAsync(string refreshToken, string? ip, string? userAgent, CancellationToken ct);
    Task LogoutAsync(string refreshToken, string? ip, CancellationToken ct);
}
