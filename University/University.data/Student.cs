using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.data
{
    public class Student : Person
    {
        #region Properties
        //Herencia
        public int Enrollment { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Course> Courses { get; set; }
        #endregion
    }
}
