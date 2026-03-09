using StudentManagementSystem.Repositories.Interfaces;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services.Interfaces;

namespace StudentManagementSystem.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<AuthService> _logger;

        public AuthService(IUserRepository userRepository, ILogger<AuthService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<(bool success, string message, User? user)> RegisterAsync(string firstName, string lastName, string email, string password)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    return (false, "Email and password are required.", null);
                }

                if (password.Length < 6)
                {
                    return (false, "Password must be at least 6 characters long.", null);
                }

                // Check if user already exists
                var existingUser = await _userRepository.GetByEmailAsync(email);
                if (existingUser != null)
                {
                    return (false, "User with this email already exists.", null);
                }

                // Create new user
                var user = new User
                {
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                    Role = "Student",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                };

                await _userRepository.AddAsync(user);
                await _userRepository.SaveChangesAsync();

                _logger.LogInformation($"User registered successfully: {email}");
                return (true, "Registration successful. Please login.", user);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during registration: {ex.Message}");
                return (false, "An error occurred during registration. Please try again.", null);
            }
        }

        public async Task<(bool success, string message, User? user)> LoginAsync(string email, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    return (false, "Email and password are required.", null);
                }

                var user = await _userRepository.GetByEmailAsync(email);
                if (user == null)
                {
                    return (false, "Invalid email or password.", null);
                }

                if (!user.IsActive)
                {
                    return (false, "Your account has been deactivated.", null);
                }

                if (!VerifyPassword(password, user.PasswordHash))
                {
                    return (false, "Invalid email or password.", null);
                }

                user.LastLogin = DateTime.UtcNow;
                _userRepository.Update(user);
                await _userRepository.SaveChangesAsync();

                _logger.LogInformation($"User logged in successfully: {email}");
                return (true, "Login successful.", user);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during login: {ex.Message}");
                return (false, "An error occurred during login. Please try again.", null);
            }
        }

        public bool VerifyPassword(string password, string hash)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, hash);
            }
            catch
            {
                return false;
            }
        }
    }
}
