using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.data
{
    public class Person
    {
        #region Properties
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Error", MinimumLength = 2)]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Error", MinimumLength = 2)]
        public string LastName { get; set; }
        #endregion

        #region Navigation Properties
        #endregion
    }
}
