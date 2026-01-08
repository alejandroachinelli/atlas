using Atlas.Modules.Identity.Entities;
using Atlas.Modules.Identity.Interfaces.Repositories;
using Atlas.Modules.Identity.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Atlas.Modules.Identity.Repositories;

public class UserRepository(IdentityDbContext db) : IUserRepository
{
    public Task<User?> GetByEmailNormalizedAsync(string emailNormalized, CancellationToken ct) =>
        db.Users.Include(u => u.RefreshTokens)
            .FirstOrDefaultAsync(u => u.EmailNormalized == emailNormalized, ct);

    public Task<User?> GetByIdAsync(Guid id, CancellationToken ct) =>
        db.Users.Include(u => u.RefreshTokens)
            .FirstOrDefaultAsync(u => u.Id == id, ct);

    public async Task AddAsync(User user, CancellationToken ct) =>
        await db.Users.AddAsync(user, ct);

    public Task SaveChangesAsync(CancellationToken ct) =>
        db.SaveChangesAsync(ct);
}
