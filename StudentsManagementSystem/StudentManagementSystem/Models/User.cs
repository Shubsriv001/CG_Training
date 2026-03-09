using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(256, MinimumLength = 5, ErrorMessage = "Email must be between 5 and 256 characters")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(256, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string PasswordHash { get; set; } = string.Empty;

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 100 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 100 characters")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; } = "Student"; // Student or Admin

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LastLogin { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation property
        public Student? Student { get; set; }
    }
}
