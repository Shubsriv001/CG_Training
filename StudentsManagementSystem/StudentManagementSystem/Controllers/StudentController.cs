using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services.Interfaces;

namespace StudentManagementSystem.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IHostelService _hostelService;
        private readonly ILogger<StudentController> _logger;

        public StudentController(
            IStudentService studentService,
            IHostelService hostelService,
            ILogger<StudentController> logger)
        {
            _studentService = studentService;
            _hostelService = hostelService;
            _logger = logger;
        }

        private bool IsUserLoggedIn()
        {
            return HttpContext.Session.GetInt32("UserId").HasValue;
        }

        private int GetCurrentUserId()
        {
            return HttpContext.Session.GetInt32("UserId") ?? 0;
        }

        private string GetCurrentUserRole()
        {
            return HttpContext.Session.GetString("UserRole") ?? "";
        }

        [HttpGet("register-form")]
        public async Task<IActionResult> RegisterForm()
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            int userId = GetCurrentUserId();
            var student = await _studentService.GetStudentByUserIdAsync(userId);

            if (student != null)
            {
                return RedirectToAction("Index", "Dashboard");
            }

            var hostels = await _hostelService.GetAllHostelsAsync();
            ViewBag.Hostels = hostels;

            return View();
        }

        [HttpPost("register-form")]
        public async Task<IActionResult> RegisterForm(Student student)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            if (!ModelState.IsValid)
            {
                var hostels = await _hostelService.GetAllHostelsAsync();
                ViewBag.Hostels = hostels;
                return View(student);
            }

            int userId = GetCurrentUserId();
            student.UserId = userId;

            var (success, message, createdStudent) = await _studentService.CreateStudentAsync(student);

            if (success)
            {
                _logger.LogInformation($"Student {student.StudentName} registered successfully");
                return RedirectToAction("Index", "Dashboard");
            }

            ModelState.AddModelError("", message);
            var hostelsList = await _hostelService.GetAllHostelsAsync();
            ViewBag.Hostels = hostelsList;
            return View(student);
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            int userId = GetCurrentUserId();
            string userRole = GetCurrentUserRole();

            var student = await _studentService.GetStudentByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            // Check authorization: Students can only edit their own data
            if (userRole != "Admin" && student.UserId != userId)
            {
                return Forbid();
            }

            var hostels = await _hostelService.GetAllHostelsAsync();
            ViewBag.Hostels = hostels;

            return View(student);
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            int userId = GetCurrentUserId();
            string userRole = GetCurrentUserRole();

            var existingStudent = await _studentService.GetStudentByIdAsync(id);
            if (existingStudent == null)
            {
                return NotFound();
            }

            // Check authorization
            if (userRole != "Admin" && existingStudent.UserId != userId)
            {
                return Forbid();
            }

            if (id != student.StudentId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                var hostels = await _hostelService.GetAllHostelsAsync();
                ViewBag.Hostels = hostels;
                return View(student);
            }

            // Preserve important fields
            student.UserId = existingStudent.UserId;
            student.CreatedAt = existingStudent.CreatedAt;

            var (success, message) = await _studentService.UpdateStudentAsync(student);

            if (success)
            {
                _logger.LogInformation($"Student {student.StudentName} updated successfully");
                return RedirectToAction("Index", "Dashboard");
            }

            ModelState.AddModelError("", message);
            var hostelsList = await _hostelService.GetAllHostelsAsync();
            ViewBag.Hostels = hostelsList;
            return View(student);
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            string userRole = GetCurrentUserRole();

            // Only admins can delete students
            if (userRole != "Admin")
            {
                return Forbid();
            }

            var student = await _studentService.GetStudentByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            var (success, message) = await _studentService.DeleteStudentAsync(id);

            if (success)
            {
                _logger.LogInformation($"Student {student.StudentName} deleted successfully");
                return RedirectToAction("Index", "Admin");
            }

            TempData["ErrorMessage"] = message;
            return RedirectToAction("Index", "Admin");
        }
    }
}
