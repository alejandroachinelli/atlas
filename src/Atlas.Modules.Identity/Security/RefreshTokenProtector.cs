using Atlas.Modules.Identity.Interfaces.Security;
using System.Security.Cryptography;
using System.Text;

namespace Atlas.Modules.Identity.Security;

public class RefreshTokenProtector : IRefreshTokenProtector
{
    private readonly string _pepper;

    public RefreshTokenProtector(string pepper)
    {
        _pepper = pepper;
    }

    public string Hash(string refreshToken)
    {
        var input = $"{refreshToken}:{_pepper}";
        var bytes = Encoding.UTF8.GetBytes(input);
        var hash = SHA256.HashData(bytes);
        return Convert.ToHexString(hash);
    }
}
