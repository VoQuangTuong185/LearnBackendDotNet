using Microsoft.EntityFrameworkCore;
using MyWebsiteAPI.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteAPI.Datas
{
    public class ManageDBContext : DbContext
    {
        public ManageDBContext(DbContextOptions<ManageDBContext> options) : base(options)
        {
                
        }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
