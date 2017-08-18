using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.data
{
    public class Supplier : Entity
    {
        #region Properties
        //Inherits Id and Name from Entity parent class
        public string Email { get; set; }
        #region Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
        #endregion
        #endregion
    }
}
