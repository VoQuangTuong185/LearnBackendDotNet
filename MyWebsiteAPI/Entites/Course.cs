using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteAPI.Entites
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        [ForeignKey("TeacherID")]
        public virtual Teacher Teacher { get; set; }
    }
}
