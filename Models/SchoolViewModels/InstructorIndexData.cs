namespace RazorContoso.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Module> Modules { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}