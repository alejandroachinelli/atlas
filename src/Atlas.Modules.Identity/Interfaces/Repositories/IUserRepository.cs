using Atlas.Modules.Identity.Entities;

namespace Atlas.Modules.Identity.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User?> GetByEmailNormalizedAsync(string emailNormalized, CancellationToken ct);
    Task<User?> GetByIdAsync(Guid id, CancellationToken ct);
    Task AddAsync(User user, CancellationToken ct);
    Task SaveChangesAsync(CancellationToken ct);
}
