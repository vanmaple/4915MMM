using SDP_EntityModels;
using Project.Models;

namespace Project.Services
{
    public interface IAuthService
    {
        string GenerateToken(User user);
        bool VerifyPassword(string password, string passwordHash);
        string HashPassword(string password);
        string GenerateToken(IUser user);
    }
}
    