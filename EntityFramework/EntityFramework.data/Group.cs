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
    public class Group
    {
        #region Properties
        public int Id { get; set; }
        public int Hours { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Student> Students { get; set; }
        #endregion
    }
}
