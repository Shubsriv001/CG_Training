using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _studentRepository;

        public StudentController(IStudent studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            var result = _studentRepository.AddStudent(student);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpGet("GetStudent/{studentId}")]
        public IActionResult GetStudent(int studentId)
        {
            var student = _studentRepository.GetStudent(studentId);
            if (student == null) return NotFound("No Records Found");
            return Ok(student);
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            var result = _studentRepository.UpdateStudent(student);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpDelete("DeleteStudent/{studentId}")]
        public IActionResult DeleteStudent(int studentId)
        {
            var result = _studentRepository.DeleteStudent(studentId);
            if (result) return Ok();
            return NotFound("No Records Found");
        }

        [HttpGet("ByCourseTitle/{courseTitle}")]
        public IActionResult ByCourseTitle(string courseTitle)
        {
            var students = _studentRepository.GetStudentsByCourseTitle(courseTitle);
            if (students == null || !students.Any()) return NotFound("No Records Found");
            return Ok(students);
        }
    }
}
