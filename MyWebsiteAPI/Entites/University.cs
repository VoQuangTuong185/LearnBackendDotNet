using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteAPI.Entites
{
    public class University
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
