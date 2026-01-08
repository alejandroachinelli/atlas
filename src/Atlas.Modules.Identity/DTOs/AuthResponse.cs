namespace Atlas.Modules.Identity.DTOs;

public record AuthResponse(string AccessToken, DateTimeOffset ExpiresAt);
