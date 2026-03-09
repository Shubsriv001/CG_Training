using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Services.Interfaces;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StudentManagementSystem.Controllers
{
    [Route("[controller]")]
    public class DashboardController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(IStudentService studentService, ILogger<DashboardController> logger)
        {
            _studentService = studentService;
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

        [HttpGet("")]
        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            int userId = GetCurrentUserId();
            var student = await _studentService.GetStudentByUserIdAsync(userId);

            if (student == null)
            {
                return RedirectToAction("RegisterForm", "Student");
            }

            return View(student);
        }

        [HttpGet("id-card/{studentId}")]
        public async Task<IActionResult> GenerateIdCard(int studentId)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            int userId = GetCurrentUserId();
            string userRole = HttpContext.Session.GetString("UserRole") ?? "";

            var student = await _studentService.GetStudentByIdAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }

            // Authorization check
            if (userRole != "Admin" && student.UserId != userId)
            {
                return Forbid();
            }

            return View(student);
        }

        [HttpGet("id-card-pdf/{studentId}")]
        public async Task<IActionResult> GenerateIdCardPdf(int studentId)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Auth");
            }

            int userId = GetCurrentUserId();
            string userRole = HttpContext.Session.GetString("UserRole") ?? "";

            var student = await _studentService.GetStudentByIdAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }

            // Authorization check
            if (userRole != "Admin" && student.UserId != userId)
            {
                return Forbid();
            }

            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    Document document = new Document(PageSize.A5);
                    PdfWriter.GetInstance(document, memoryStream);
                    document.Open();

                    // Add title
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                    document.Add(new Paragraph("STUDENT ID CARD", titleFont) { Alignment = Element.ALIGN_CENTER });
                    document.Add(new Paragraph(""));

                    // Add content
                    var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                    var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);

                    document.Add(new Paragraph($"Student ID: {student.StudentId}", boldFont));
                    document.Add(new Paragraph($"Name: {student.StudentName}", normalFont));
                    document.Add(new Paragraph($"Father Name: {student.FatherName}", normalFont));
                    document.Add(new Paragraph($"Email: {student.Email}", normalFont));
                    document.Add(new Paragraph($"Phone: {student.Phone}", normalFont));
                    document.Add(new Paragraph($"Semester: {student.Semester}", normalFont));
                    document.Add(new Paragraph(""));

                    if (student.Hostel != null)
                    {
                        document.Add(new Paragraph("Hostel Information:", boldFont));
                        document.Add(new Paragraph($"Hostel Name: {student.Hostel.HostelName}", normalFont));
                        document.Add(new Paragraph($"Room Number: {student.Hostel.RoomNumber}", normalFont));
                    }
                    else
                    {
                        document.Add(new Paragraph("No Hostel Assigned", boldFont));
                    }

                    document.Add(new Paragraph(""));
                    document.Add(new Paragraph($"Generated: {DateTime.Now:dd/MM/yyyy}", normalFont));

                    document.Close();

                    byte[] bytes = memoryStream.ToArray();
                    return File(bytes, "application/pdf", $"StudentIdCard_{student.StudentId}.pdf");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error generating ID card PDF: {ex.Message}");
                TempData["ErrorMessage"] = "Error generating ID card.";
                return RedirectToAction("Index");
            }
        }
    }
}
