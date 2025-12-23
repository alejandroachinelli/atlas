namespace Atlas.Modules.Identity.Interfaces.Security;

public interface IRefreshTokenProtector
{
    string Hash(string refreshToken);
}
