using UniversityApi.Models;

namespace UniversityApi.Interfaces
{
    public interface IInstructor
    {
        bool AddInstructor(Instructor instructor);
        Instructor GetInstructor(int instructorId);
        bool UpdateInstructor(Instructor instructor);
        bool DeleteInstructor(int instructorId);
        IEnumerable<Instructor> GetInstructorsWithCourseCountAbove(int count);
        IEnumerable<Instructor> GetInstructorsWithMostEnrollments();
    }
}
