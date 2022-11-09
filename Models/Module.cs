using System.ComponentModel.DataAnnotations.Schema;

namespace RazorContoso.Models
{
    public class Module
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}