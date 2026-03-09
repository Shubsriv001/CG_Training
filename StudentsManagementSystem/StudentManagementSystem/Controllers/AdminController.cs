using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Services.Interfaces;

namespace StudentManagementSystem.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IHostelService _hostelService;
        private readonly ILogger<AdminController> _logger;

        public AdminController(
            IStudentService studentService,
            IHostelService hostelService,
            ILogger<AdminController> logger)
        {
            _studentService = studentService;
            _hostelService = hostelService;
            _logger = logger;
        }

        private bool IsAdmin()
        {
            var role = HttpContext.Session.GetString("UserRole");
            return role == "Admin";
        }

        private bool IsUserLoggedIn()
        {
            return HttpContext.Session.GetInt32("UserId").HasValue;
        }

        [HttpGet("")]
        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            var students = await _studentService.GetAllStudentsAsync();
            return View(students);
        }

        [HttpGet("manage-hostels")]
        public async Task<IActionResult> ManageHostels()
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            var hostels = await _hostelService.GetAllHostelsAsync();
            return View(hostels);
        }

        [HttpGet("create-hostel")]
        public IActionResult CreateHostel()
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            return View();
        }

        [HttpPost("create-hostel")]
        public async Task<IActionResult> CreateHostel(Models.Hostel hostel)
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            if (!ModelState.IsValid)
            {
                return View(hostel);
            }

            var (success, message, createdHostel) = await _hostelService.CreateHostelAsync(hostel);

            if (success)
            {
                _logger.LogInformation($"Hostel {hostel.HostelName} created successfully");
                return RedirectToAction("ManageHostels");
            }

            ModelState.AddModelError("", message);
            return View(hostel);
        }

        [HttpGet("edit-hostel/{id}")]
        public async Task<IActionResult> EditHostel(int id)
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            var hostel = await _hostelService.GetHostelByIdAsync(id);
            if (hostel == null)
            {
                return NotFound();
            }

            return View(hostel);
        }

        [HttpPost("edit-hostel/{id}")]
        public async Task<IActionResult> EditHostel(int id, Models.Hostel hostel)
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            if (id != hostel.HostelId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(hostel);
            }

            var (success, message) = await _hostelService.UpdateHostelAsync(hostel);

            if (success)
            {
                _logger.LogInformation($"Hostel {hostel.HostelName} updated successfully");
                return RedirectToAction("ManageHostels");
            }

            ModelState.AddModelError("", message);
            return View(hostel);
        }

        [HttpPost("delete-hostel/{id}")]
        public async Task<IActionResult> DeleteHostel(int id)
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            var (success, message) = await _hostelService.DeleteHostelAsync(id);

            if (success)
            {
                _logger.LogInformation($"Hostel deleted successfully");
                return RedirectToAction("ManageHostels");
            }

            TempData["ErrorMessage"] = message;
            return RedirectToAction("ManageHostels");
        }

        [HttpGet("view-student/{id}")]
        public async Task<IActionResult> ViewStudent(int id)
        {
            if (!IsUserLoggedIn() || !IsAdmin())
            {
                return RedirectToAction("Login", "Auth");
            }

            var student = await _studentService.GetStudentByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
