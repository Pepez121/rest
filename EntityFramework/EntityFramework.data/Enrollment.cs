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
    [Table("Enrollment", Schema = "Enrollments")]
    public class Enrollment
    {
        public Enrollment()
        {

        }
        #region Properties
        [Key]
        public int EnrollmentID { get; set; }

        
        public int CourseId { get; set; }

        
        public int StudentId { get; set; }

        public int Grade { get; set; }
        #endregion

        #region Navigation Properties
        //Navigation Properties
        [ForeignKey("CourseId")]
        public virtual Course Courses { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Students { get; set; }
        #endregion
    }
}
