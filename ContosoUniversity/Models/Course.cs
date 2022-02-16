using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course: Identifiable<int>
    {
        [Key]
        [Attr]
        override
        public int Id { get; set; }

        [Attr]
        public string Title { get; set; }

        [Attr]
        public int Credits { get; set; }

        [Attr]
        public int DepartmentID { get; set; }

        [HasOne]
        public Department Department { get; set; }

        [HasMany]
        public ICollection<Enrollment> Enrollments { get; set; }

        [HasMany]
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
