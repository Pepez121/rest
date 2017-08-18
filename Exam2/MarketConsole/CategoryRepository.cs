using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.data;
using System.Data.Entity;

namespace MarketConsole
{
    public class CategoryRepository : IDelete
    {
        private DbMarket DbContext = new DbMarket();

        public void Add(string name, string description)
        {
            var category = new Category() { Name = name, Description = description };
            DbContext.Category.Add(category);
            DbContext.SaveChanges();
        }

        public void Update(int id, string name, string description)
        {
            var category = DbContext.Category.First(x => x.Id == id);
            category.Name = name;
            category.Description = description;
            DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            DbContext.Category.Remove(DbContext.Category.First(c => c.Id == id));
            DbContext.SaveChanges();
        }

        public void LoadCategories()
        {
            CategoryRepository CatRep = new CategoryRepository();
            CatRep.Add("Food", "All products that you can eat");
            CatRep.Add("Technology", "Products that are provided by technology companies.");
            CatRep.Add("Beverages", "All products that you can drink.");
            CatRep.Add("Office Supplies", "All products that are useful for your school or office.");
            CatRep.Add("Clothes", "All products that you can wear.");
        }
    }
}
