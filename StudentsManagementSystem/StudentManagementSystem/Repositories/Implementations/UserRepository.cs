using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetUserWithStudentAsync(int userId)
        {
            return await _dbSet
                .Include(u => u.Student)
                .ThenInclude(s => s!.Hostel)
                .Include(u => u.Student)
                .ThenInclude(s => s!.Marks)
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }
    }
}
