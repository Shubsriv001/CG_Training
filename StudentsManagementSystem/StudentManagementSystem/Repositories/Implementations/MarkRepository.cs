using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories.Implementations
{
    public class MarkRepository : Repository<Mark>, IMarkRepository
    {
        public MarkRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Mark>> GetMarksByStudentIdAsync(int studentId)
        {
            return await _dbSet
                .Where(m => m.StudentId == studentId)
                .ToListAsync();
        }
    }
}
