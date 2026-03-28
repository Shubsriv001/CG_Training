using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class InstructorRepository : IInstructor
    {
        private readonly UniversityContext _context;

        public InstructorRepository(UniversityContext context)
        {
            _context = context;
        }

        public bool AddInstructor(Instructor instructor)
        {
            var existing = _context.Instructors.Find(instructor.InstructorId);
            if (existing != null) return false;
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return true;
        }

        public Instructor GetInstructor(int instructorId)
        {
            return _context.Instructors.Find(instructorId);
        }

        public bool UpdateInstructor(Instructor instructor)
        {
            var existing = _context.Instructors.Find(instructor.InstructorId);
            if (existing == null) return false;
            existing.Name = instructor.Name;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteInstructor(int instructorId)
        {
            var instructor = _context.Instructors.Find(instructorId);
            if (instructor == null) return false;
            _context.Instructors.Remove(instructor);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Instructor> GetInstructorsWithCourseCountAbove(int count)
        {
            return _context.InstructorCourses
                .Include(ic => ic.Instructor)
                .GroupBy(ic => ic.InstructorId)
                .Where(g => g.Count() > count)
                .Select(g => g.First().Instructor)
                .ToList();
        }

        public IEnumerable<Instructor> GetInstructorsWithMostEnrollments()
        {
            var enrollmentCounts = _context.InstructorCourses
                .Include(ic => ic.Course)
                    .ThenInclude(c => c.Enrollments)
                .GroupBy(ic => ic.InstructorId)
                .Select(g => new
                {
                    InstructorId = g.Key,
                    EnrollmentCount = g.Sum(ic => ic.Course.Enrollments.Count)
                })
                .ToList();

            if (!enrollmentCounts.Any()) return Enumerable.Empty<Instructor>();

            int max = enrollmentCounts.Max(x => x.EnrollmentCount);

            var topIds = enrollmentCounts
                .Where(x => x.EnrollmentCount == max)
                .Select(x => x.InstructorId)
                .ToList();

            return _context.Instructors
                .Where(i => topIds.Contains(i.InstructorId))
                .ToList();
        }
    }
}
