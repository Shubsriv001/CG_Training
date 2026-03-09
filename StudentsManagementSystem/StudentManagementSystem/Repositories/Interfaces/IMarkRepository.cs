using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories.Interfaces
{
    public interface IMarkRepository : IRepository<Mark>
    {
        Task<IEnumerable<Mark>> GetMarksByStudentIdAsync(int studentId);
    }
}
