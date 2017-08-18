using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.data
{
    public class Category : Entity
    {
        #region Properties
        //Inherits Id and Name from Entity parent class
        public string Description { get; set; }
        #region Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
        #endregion
        #endregion
    }
}
