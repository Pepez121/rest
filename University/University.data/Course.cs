using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.data
{
    public class Course
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Student> Students { get; set; }
        #endregion
    }
}
