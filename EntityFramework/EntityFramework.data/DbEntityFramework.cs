using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.data
{
    public class DbEntityFramework : DbContext
    {
        //Decirle a DbContext dónde está la BD
        public DbEntityFramework() : base("Data Source=(local); Initial Catalog=School; User ID=Medina; Password=Jls.Mp.43") //Connection String
        {

        }

        //Entity Set
        public DbSet<Course> Course { get; set; } 
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        //Cities - Vendors
        public DbSet<DA_Vendor> Vendor { get; set; }
        public DbSet<DA_City> City { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent API para 1 a 1
            //Student es el padre de la relación entre Student y StudentAddress
            modelBuilder.Entity<Student>()
                .HasOptional(x => x.Address) //Address porque es la nav prop, es el campo que sirve para relacionar las dos entidades
                .WithRequired(s => s.Student); //Student Address SÍ REQUIERE un Student para que exista la dirección

            //modelBuilder.Entity<StudentAddress>()
            //    .HasRequired(sa => sa.Student)
            //    .WithOptional(a => a.Address);

            //Fluent API uno a muchos
            modelBuilder.Entity<Group>()
                .HasMany<Student>(g => g.Students) //El <student> es opcional
                .WithRequired(s => s.Group);

            //modelBuilder.Entity<Student>()
            //    .HasRequired<Group>(s => s.Group)
            //    .WithMany(g => g.Students);

            //Fluent API uno a muchos
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithRequired(c => c.Student);

            //modelBuilder.Entity<Course>()
            //    .HasRequired(c => c.Student)
            //    .WithMany(s => s.Courses);

            //Fluent API muchos a muchos
            modelBuilder.Entity<City>()
                .HasMany(c => c.Vendors)
                .WithMany(v => v.Cities)
                .Map(cv => {
                    cv.MapLeftKey("VendorId"); //Mapea llave
                    cv.MapRightKey("CityId"); //Mapea llave
                    cv.ToTable("CityVendor", "University");
                }); 

            //modelBuilder.Entity<Vendor>()
            //    .HasMany(v => v.Cities)
            //    .WithMany(c => c.Vendors);
        }

        

        
    }
}
