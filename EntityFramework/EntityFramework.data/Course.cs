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
    [Table("Course", Schema = "Courses")]
    public class Course
    {
        public Course()
        {

        }
        #region Properties
        [Key]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Error", MinimumLength = 10)]
        public string Title { get; set; }

        public int Credits { get; set; }

        public int Hours { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Enrollment> Enrollment { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
        #endregion
    }
}
