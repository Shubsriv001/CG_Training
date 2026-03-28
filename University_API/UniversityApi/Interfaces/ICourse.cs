using UniversityApi.Models;

namespace UniversityApi.Interfaces
{
    public interface ICourse
    {
        bool AddCourse(Course course);
        Course GetCourse(int courseId);
        bool UpdateCourse(Course course);
        bool DeleteCourse(int courseId);
        IEnumerable<Course> GetCoursesWithEnrollmentsAboveGrade(int grade);
        IEnumerable<Course> GetCoursesByInstructorName(string instructorName);
    }
}
