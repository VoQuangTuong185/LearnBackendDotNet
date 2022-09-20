using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteAPI.Entites
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
