using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UniversityApi.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public ICollection<Enrollment>? Enrollments { get; set; }
        [JsonIgnore]
        public ICollection<InstructorCourse>? InstructorCourses { get; set; }
    }
}
