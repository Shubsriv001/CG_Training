using UniversityApi.Models;

namespace UniversityApi.Interfaces
{
    public interface IStudent
    {
        bool AddStudent(Student student);
        Student GetStudent(int studentId);
        bool UpdateStudent(Student student);
        bool DeleteStudent(int studentId);
        IEnumerable<Student> GetStudentsByCourseTitle(string courseTitle);
    }
}
