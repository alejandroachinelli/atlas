using Atlas.Modules.Identity.Entities;
using Atlas.Modules.Identity.Interfaces.Repositories;
using Atlas.Modules.Identity.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Atlas.Modules.Identity.Repositories;

public class RefreshTokenRepository(IdentityDbContext db) : IRefreshTokenRepository
{
    public Task<RefreshToken?> GetByTokenHashAsync(string tokenHash, CancellationToken ct) =>
        db.RefreshTokens.Include(t => t.User)
            .FirstOrDefaultAsync(t => t.TokenHash == tokenHash, ct);

    public async Task AddAsync(RefreshToken token, CancellationToken ct) =>
        await db.RefreshTokens.AddAsync(token, ct);

    public Task SaveChangesAsync(CancellationToken ct) =>
        db.SaveChangesAsync(ct);
}
