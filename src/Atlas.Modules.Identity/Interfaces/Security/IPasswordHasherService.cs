namespace Atlas.Modules.Identity.Interfaces.Security;

public interface IPasswordHasherService
{
    string HashPassword(string password);
    bool VerifyPassword(string hashedPassword, string providedPassword);
}
