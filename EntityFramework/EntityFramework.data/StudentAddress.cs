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
    [Table("StudentAddress", Schema = "StudentAddresses")]
    public class StudentAddress
    {


        [Key, ForeignKey("Student")]
        public int StudentAddressId { get; set; }

        [StringLength(50, ErrorMessage = "Error", MinimumLength = 10)]
        public string Address { get; set; }

        [StringLength(20, ErrorMessage = "Error", MinimumLength = 3)]        
        public string City { get; set; }
        [StringLength(20, ErrorMessage = "Error", MinimumLength = 3)]
        public string State { get; set; }

        #region Navigation Properties
        public virtual Student Student { get; set; }
        #endregion


    }
}
