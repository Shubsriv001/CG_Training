using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student?> GetStudentWithDetailsAsync(int studentId);
        Task<Student?> GetStudentByUserIdAsync(int userId);
        Task<IEnumerable<Student>> GetAllStudentsWithDetailsAsync();
    }
}
