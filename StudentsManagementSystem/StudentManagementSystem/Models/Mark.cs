using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models
{
    public class Mark
    {
        [Key]
        public int MarkId { get; set; }

        [Required(ErrorMessage = "Student ID is required")]
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Subject Name is required")]
        [StringLength(100)]
        public string SubjectName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Marks are required")]
        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public decimal MarksObtained { get; set; }

        [Required(ErrorMessage = "Total Marks is required")]
        [Range(1, 200, ErrorMessage = "Total Marks must be greater than 0")]
        public decimal TotalMarks { get; set; } = 100;

        public decimal Percentage
        {
            get
            {
                return (MarksObtained / TotalMarks) * 100;
            }
        }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public Student? Student { get; set; }
    }
}
