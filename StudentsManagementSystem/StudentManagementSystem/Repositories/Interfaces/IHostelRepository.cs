using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories.Interfaces
{
    public interface IHostelRepository : IRepository<Hostel>
    {
        Task<Hostel?> GetByNameAsync(string hostelName);
    }
}
