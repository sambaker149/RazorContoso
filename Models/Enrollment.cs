using System.ComponentModel.DataAnnotations;

namespace RazorContoso.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Module Module { get; set; }

        // Navigation Properties
        public Student Student { get; set; }
    }
}