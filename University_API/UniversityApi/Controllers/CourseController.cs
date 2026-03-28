using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse _courseRepository;

        public CourseController(ICourse courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPost("AddCourse")]
        public IActionResult AddCourse([FromBody] Course course)
        {
            var result = _courseRepository.AddCourse(course);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpGet("GetCourse/{courseId}")]
        public IActionResult GetCourse(int courseId)
        {
            var course = _courseRepository.GetCourse(courseId);
            if (course == null) return NotFound("No Records Found");
            return Ok(course);
        }

        [HttpPut("UpdateCourse")]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
            var result = _courseRepository.UpdateCourse(course);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpDelete("DeleteCourse/{courseId}")]
        public IActionResult DeleteCourse(int courseId)
        {
            var result = _courseRepository.DeleteCourse(courseId);
            if (result) return Ok();
            return NotFound("No Records Found");
        }

        [HttpGet("WithEnrollmentsAboveGrade/{grade}")]
        public IActionResult WithEnrollmentsAboveGrade(int grade)
        {
            var courses = _courseRepository.GetCoursesWithEnrollmentsAboveGrade(grade);
            if (courses == null || !courses.Any()) return NotFound("No Records Found");
            return Ok(courses);
        }

        [HttpGet("ByInstructorName/{instructorName}")]
        public IActionResult ByInstructorName(string instructorName)
        {
            var courses = _courseRepository.GetCoursesByInstructorName(instructorName);
            if (courses == null || !courses.Any()) return NotFound("No Records Found");
            return Ok(courses);
        }
    }
}
