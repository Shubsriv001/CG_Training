using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories.Implementations
{
    public class HostelRepository : Repository<Hostel>, IHostelRepository
    {
        public HostelRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Hostel?> GetByNameAsync(string hostelName)
        {
            return await _dbSet.FirstOrDefaultAsync(h => h.HostelName == hostelName);
        }
    }
}
