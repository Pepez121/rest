using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.data
{
    public class EmployeeCategory
    {
        #region Properties
        public int Id { get; set; }
        public string CategoryName { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion
    }
}
