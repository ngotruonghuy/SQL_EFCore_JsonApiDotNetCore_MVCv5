using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment: Identifiable<int>
    {
        [Key]
        [Attr]
        override
        public int Id { get; set; }
        
        [Attr]
        public int CourseID { get; set; }

        [Attr]
        public int StudentID { get; set; }

        [Attr]
        public Grade? Grade { get; set; }

        [HasOne]
        public Course Course { get; set; }

        [HasOne]
        public Student Student { get; set; }
    }
}
