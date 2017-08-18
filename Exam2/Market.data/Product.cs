using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.data
{
    public class Product : Entity
    {
        #region Properties
        //Inherits Id and Name from Entity parent class
        public float Price { get; set; }
        #endregion

        #region Navigation Properties
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        #endregion
    }
}
