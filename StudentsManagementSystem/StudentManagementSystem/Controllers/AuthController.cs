using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services.Interfaces;
using StudentManagementSystem.ViewModels;

namespace StudentManagementSystem.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var (success, message, user) = await _authService.LoginAsync(model.Email, model.Password);

            if (success && user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.UserId);
                HttpContext.Session.SetString("UserEmail", user.Email);
                HttpContext.Session.SetString("UserRole", user.Role);
                HttpContext.Session.SetString("UserName", $"{user.FirstName} {user.LastName}");

                _logger.LogInformation($"User {user.Email} logged in successfully");

                if (user.Role == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }

            ModelState.AddModelError("", message);
            return View(model);
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "Passwords do not match.");
                return View(model);
            }

            var (success, message, user) = await _authService.RegisterAsync(
                model.FirstName,
                model.LastName,
                model.Email,
                model.Password);

            if (success)
            {
                TempData["SuccessMessage"] = "Registration successful! Please login with your credentials.";
                return RedirectToAction("Login");
            }

            ModelState.AddModelError("", message);
            return View(model);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
