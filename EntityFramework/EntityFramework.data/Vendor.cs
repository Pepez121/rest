using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.data
{
    public class Vendor
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<City> Cities { get; set; }
        public int CityId { get; set; }

        #endregion
    }
}
