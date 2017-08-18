using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Diccionario
            var states = new Dictionary<string, string>()
            {
                { "CA", "California" },
                { "NY", "New York" },
                { "WA", "Washington" }
            };

            VendorRepository repository = new VendorRepository();
            var vendors = repository.RetrieveWithKeys();
            //Console.WriteLine(vendor["ABC Corp"].CompanyName);

            foreach (var key in vendors.Keys)
            {
                Console.WriteLine("Company Name: " + vendors[key].CompanyName + " | Email: " + vendors[key].Email);
            }

            //Otra forma de imprimir sin usar concatenacion del +
            foreach (var element in vendors)
            {
                var vend = element.Value;
                var key = element.Key;
                Console.WriteLine($"Key: { key } Value: {vend}");
            }
            Console.Read();
            #endregion
        }
    }
}
