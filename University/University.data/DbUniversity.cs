using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace University.data
{
    public class DbUniversity : DbContext
    {
        public DbUniversity() : base("Data Source=(local); Initial Catalog=University; User ID=Medina; Password=Jls.Mp.43")
        {

        }
        
        //Entity Set

        public DbSet<Office> Office { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategory { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Departments)
                .WithMany(d => d.Employees);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Office)
                .WithMany(o => o.Employees);

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.EmployeeCategory)
                .WithMany(ec => ec.Employees);

            //modelBuilder.Entity<City>()
            //    .HasMany(c => c.Vendors)
            //    .WithMany(v => v.Cities)
            //    .Map(cv => {
            //        cv.MapLeftKey("VendorId"); //Mapea llave
            //        cv.MapRightKey("CityId"); //Mapea llave
            //        cv.ToTable("CityVendor", "University");
            //    });
        }
    }
}
