using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.data;
using System.Data.Entity;

namespace MarketConsole
{
    public class ProductRepository : IDelete
    {
        private DbMarket DbContext = new DbMarket();
        public void Add(string name, float price, int catId, int supId)
        {
            var product = new Product() { CategoryId = catId,
                                          SupplierId = supId,
                                          Name = name,
                                          Price = price};
            DbContext.Product.Add(product);
            DbContext.SaveChanges();
        }

        public void Update(int id, string name, float price, int catId, int supId)
        {
            var product = DbContext.Product.First(x => x.Id == id);
            product.Name = name;
            product.Price = price;
            product.CategoryId = catId;
            product.SupplierId = supId;
            DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            DbContext.Product.Remove(DbContext.Product.First(x => x.Id == id));
            DbContext.SaveChanges();
        }

        public void LoadProducts()
        {
            ProductRepository ProdRep = new ProductRepository();
            ProdRep.Add("Pie", 14.50f, 1, 1);
            ProdRep.Add("Cake", 34.5f, 1, 1);
            ProdRep.Add("Donuts", 10, 1, 1);
            ProdRep.Add("Academy", 5000f, 2, 4);
            ProdRep.Add("Caramel Frappuchino", 56.90f, 3, 3);

        }
    }
}
