using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.data
{
    [Table("Student", Schema = "Students")]
    public class Student
    {
        public Student()
        {

        }
        #region Properties
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Error", MinimumLength = 10)]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public DateTime BirthDate { get; set; }

        #endregion

        #region Navigation Properties
        public virtual ICollection<Enrollment> Enrollment { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual StudentAddress Address { get; set; }
        public int GroupId { get; set; } //Foreign Key
        public virtual Group Group { get; set; }
        #endregion

    }
}
