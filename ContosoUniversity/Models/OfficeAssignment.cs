using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment: Identifiable<int>
    {
        [Key]
        [Attr]
        override
        public int Id { get; set; }
        
        [Attr]
        public string Location { get; set; }

        [HasOne]
        public Instructor Instructor { get; set; }
    }
}
