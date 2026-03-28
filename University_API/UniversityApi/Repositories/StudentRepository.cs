using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly UniversityContext _context;

        public StudentRepository(UniversityContext context)
        {
            _context = context;
        }

        public bool AddStudent(Student student)
        {
            var existing = _context.Students.Find(student.StudentId);
            if (existing != null) return false;
            _context.Students.Add(student);
            _context.SaveChanges();
            return true;
        }

        public Student GetStudent(int studentId)
        {
            return _context.Students.Find(studentId);
        }

        public bool UpdateStudent(Student student)
        {
            var existing = _context.Students.Find(student.StudentId);
            if (existing == null) return false;
            existing.Name = student.Name;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteStudent(int studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null) return false;
            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Student> GetStudentsByCourseTitle(string courseTitle)
        {
            return _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Student)
                .Where(e => e.Course.Title == courseTitle)
                .Select(e => e.Student)
                .ToList();
        }
    }
}
