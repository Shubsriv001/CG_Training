using StudentManagementSystem.Repositories.Interfaces;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services.Interfaces;

namespace StudentManagementSystem.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentService> _logger;

        public StudentService(IStudentRepository studentRepository, ILogger<StudentService> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        public async Task<(bool success, string message, Student? student)> CreateStudentAsync(Student student)
        {
            try
            {
                await _studentRepository.AddAsync(student);
                await _studentRepository.SaveChangesAsync();

                _logger.LogInformation($"Student created successfully: {student.StudentName}");
                return (true, "Student record created successfully.", student);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creating student: {ex.Message}");
                return (false, "An error occurred while creating student record.", null);
            }
        }

        public async Task<(bool success, string message)> UpdateStudentAsync(Student student)
        {
            try
            {
                student.UpdatedAt = DateTime.UtcNow;
                
                // Detach related entities to avoid update conflicts
                if (student.User != null)
                {
                    student.User = null;
                }
                if (student.Hostel != null)
                {
                    student.Hostel = null;
                }
                if (student.Marks != null)
                {
                    student.Marks = null;
                }
                
                _studentRepository.Update(student);
                await _studentRepository.SaveChangesAsync();

                _logger.LogInformation($"Student updated successfully: {student.StudentName}");
                return (true, "Student record updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating student: {ex.Message}");
                return (false, "An error occurred while updating student record.");
            }
        }

        public async Task<(bool success, string message)> DeleteStudentAsync(int studentId)
        {
            try
            {
                var student = await _studentRepository.GetByIdAsync(studentId);
                if (student == null)
                {
                    return (false, "Student not found.");
                }

                _studentRepository.Delete(student);
                await _studentRepository.SaveChangesAsync();

                _logger.LogInformation($"Student deleted successfully: {studentId}");
                return (true, "Student record deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting student: {ex.Message}");
                return (false, "An error occurred while deleting student record.");
            }
        }

        public async Task<Student?> GetStudentByIdAsync(int studentId)
        {
            return await _studentRepository.GetStudentWithDetailsAsync(studentId);
        }

        public async Task<Student?> GetStudentByUserIdAsync(int userId)
        {
            return await _studentRepository.GetStudentByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsWithDetailsAsync();
        }
    }
}
