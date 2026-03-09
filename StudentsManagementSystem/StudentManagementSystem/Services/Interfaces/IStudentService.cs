using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services.Interfaces
{
    public interface IStudentService
    {
        Task<(bool success, string message, Student? student)> CreateStudentAsync(Student student);
        Task<(bool success, string message)> UpdateStudentAsync(Student student);
        Task<(bool success, string message)> DeleteStudentAsync(int studentId);
        Task<Student?> GetStudentByIdAsync(int studentId);
        Task<Student?> GetStudentByUserIdAsync(int userId);
        Task<IEnumerable<Student>> GetAllStudentsAsync();
    }
}
