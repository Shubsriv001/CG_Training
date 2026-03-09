using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services.Interfaces
{
    public interface IAuthService
    {
        Task<(bool success, string message, User? user)> RegisterAsync(string firstName, string lastName, string email, string password);
        Task<(bool success, string message, User? user)> LoginAsync(string email, string password);
        bool VerifyPassword(string password, string hash);
    }
}
