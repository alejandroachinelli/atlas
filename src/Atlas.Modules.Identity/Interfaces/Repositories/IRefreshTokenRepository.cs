using Atlas.Modules.Identity.Entities;

namespace Atlas.Modules.Identity.Interfaces.Repositories;

public interface IRefreshTokenRepository
{
    Task<RefreshToken?> GetByTokenHashAsync(string tokenHash, CancellationToken ct);
    Task AddAsync(RefreshToken token, CancellationToken ct);
    Task SaveChangesAsync(CancellationToken ct);
}
