using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor: Identifiable<int>
    {
        [Key]
        [Attr]
        override
        public int Id { get; set; }

        [Attr]
        [StringLength(50)]
        public string LastName { get; set; }

        [Attr]
        [Column("FirstName")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [Attr]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [HasMany]
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        [HasOne]
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
