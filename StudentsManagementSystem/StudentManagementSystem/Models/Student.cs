using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Student Name must be between 2 and 100 characters")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Father Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Father Name must be between 2 and 100 characters")]
        public string FatherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Semester is required")]
        [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8")]
        public int Semester { get; set; }

        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public decimal Subject1Marks { get; set; }

        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public decimal Subject2Marks { get; set; }

        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public decimal Subject3Marks { get; set; }

        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public decimal Subject4Marks { get; set; }

        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public decimal Subject5Marks { get; set; }

        public decimal AverageMarks
        {
            get
            {
                return (Subject1Marks + Subject2Marks + Subject3Marks + Subject4Marks + Subject5Marks) / 5;
            }
        }

        [Required(ErrorMessage = "User ID is required")]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Hostel")]
        public int? HostelId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public Hostel? Hostel { get; set; }
        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
