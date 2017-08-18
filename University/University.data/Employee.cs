using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.data
{
    public class Employee : Person
    {
        #region Properties
        //Herencia de Persona
        public int Hours { get; set; }

        [StringLength(6, ErrorMessage = "Error", MinimumLength = 6)]
        public string Enrollment { get; set; }
        #endregion

        #region Navigation Properties
        public int EmployeeCategoryId { get; set; }
        public int? OfficeId { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual Office Office { get; set; }
        public virtual EmployeeCategory EmployeeCategory { get; set; }
        #endregion
    }
}
