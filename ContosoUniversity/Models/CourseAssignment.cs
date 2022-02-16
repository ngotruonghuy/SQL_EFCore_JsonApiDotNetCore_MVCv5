using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class CourseAssignment: Identifiable<int>
    {
        [Key]
        [Attr]
        public int InstructorID { get; set; }

        [Key]
        [Attr]
        public int CourseID { get; set; }

        [HasOne]
        public Instructor Instructor { get; set; }
        [HasOne]
        public Course Course { get; set; }
    }
}
