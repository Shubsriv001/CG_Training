using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories.Implementations
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Student?> GetStudentWithDetailsAsync(int studentId)
        {
            return await _dbSet
                .Include(s => s.User)
                .Include(s => s.Hostel)
                .Include(s => s.Marks)
                .FirstOrDefaultAsync(s => s.StudentId == studentId);
        }

        public async Task<Student?> GetStudentByUserIdAsync(int userId)
        {
            return await _dbSet
                .Include(s => s.User)
                .Include(s => s.Hostel)
                .Include(s => s.Marks)
                .FirstOrDefaultAsync(s => s.UserId == userId);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsWithDetailsAsync()
        {
            return await _dbSet
                .Include(s => s.User)
                .Include(s => s.Hostel)
                .Include(s => s.Marks)
                .ToListAsync();
        }
    }
}
