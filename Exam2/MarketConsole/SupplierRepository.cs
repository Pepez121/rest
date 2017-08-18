using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.data;
using System.Data.Entity;

namespace MarketConsole
{
    public class SupplierRepository : IDelete
    {
        private DbMarket DbContext = new DbMarket();
        public void Add(string name, string email)
        {
            var supplier = new Supplier() { Name = name, Email = email };
            DbContext.Supplier.Add(supplier);
            DbContext.SaveChanges();
        }

        public void Update(int id, string name, string email)
        {
            Supplier supplier = DbContext.Supplier.First(x => x.Id == id);
            supplier.Name = name;
            supplier.Email = email;
            DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            DbContext.Supplier.Remove(DbContext.Supplier.First(s => s.Id == id));
            DbContext.SaveChanges();
        }

        public void LoadSuppliers()
        {
            SupplierRepository SuppRep = new SupplierRepository();
            SuppRep.Add("Bimbo", "mail@bimbo.com.mx");
            SuppRep.Add("Pizza Hut", "mail@pizzahut.com.mx");
            SuppRep.Add("Starbucks", "mail@starbucks.com.mx");
            SuppRep.Add("Accenture", "mail@accenture.com.mx");
            SuppRep.Add("Microsoft", "mail@microsoft.com");
        }
    }
}
