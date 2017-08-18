using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class VendorRepository
    {
        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor() { VendorID = 5, CompanyName =  "ABC Group", Email = "abc@abc.com"} },
                { "XYZ Inc", new Vendor() { VendorID = 8, CompanyName =  "XYZ Inc", Email = "xyz@xyz.com"} }
            };
            return vendors;

        }
    }
}
