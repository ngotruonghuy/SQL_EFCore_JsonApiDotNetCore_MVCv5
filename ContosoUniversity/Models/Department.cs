using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department: Identifiable<int>
    {
        [Key]
        [Attr]
        override
        public int Id { get; set; }

        [Attr]
        public string Name { get; set; }

        [Attr]
        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }

        [Attr]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Attr]
        public int? InstructorID { get; set; }

        [HasOne]
        public Instructor Administrator { get; set; }

        [HasMany]
        public ICollection<Course> Courses { get; set; }
    }
}
