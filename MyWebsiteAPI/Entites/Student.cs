using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteAPI.Entites
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Gender { get; set; }
        public DateTime DayOfBirth { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        [ForeignKey("ClassID")]
        public virtual Class Class { get; set; }
    }
}
