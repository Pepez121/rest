using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.data
{
    public class Office
    {
        #region Properties
        public int Id { get; set; }
        public int Building { get; set; }
        public int FloorNumber { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion
    }
}
