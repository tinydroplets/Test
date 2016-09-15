using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EntityTest2.Models;

namespace EntityTest2.Dal
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
        }

    }
}