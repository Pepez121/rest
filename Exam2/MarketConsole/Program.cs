using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.data;

namespace MarketConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Product = new ProductRepository();
            var Supplier = new SupplierRepository();
            var Category = new CategoryRepository();

            //Creates IDs from 1 to 5
            Supplier.LoadSuppliers();
            Category.LoadCategories();
            Product.LoadProducts();

            //Updates ID 5 items
            Supplier.Update(5, "New name", "New email");
            Category.Update(5, "New Name", "New description");
            Product.Update(5, "New Product", 104.34f, 1, 1);

            //ID 6 is created
            Supplier.Add("New name2", "New email2");
            Category.Add("New Name2", "New description2");
            Product.Add("New Product2", 12.34f, 1, 1);

            //ID 6 is deleted
            Supplier.Delete(6);
            Product.Delete(6);
            Category.Delete(6);
            
            Console.Read(); ;


        }
    }
}
