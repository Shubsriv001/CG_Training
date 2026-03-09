using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models
{
    public class Hostel
    {
        [Key]
        public int HostelId { get; set; }

        [Required(ErrorMessage = "Hostel Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Hostel Name must be between 2 and 100 characters")]
        public string HostelName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Room Number is required")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Room Number must be between 1 and 20 characters")]
        public string RoomNumber { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public Student? Student { get; set; }
    }
}
