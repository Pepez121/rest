using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.data;

namespace UniversityConsole
{
    public class EmployeeCategoryRepository
    {
        private DbUniversity DbContext = new DbUniversity();

        public bool Add(string CategoryName)
        {
            try
            {
                var Category = new EmployeeCategory() { CategoryName = CategoryName };
                DbContext.EmployeeCategory.Add(Category);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<EmployeeCategory> Get()
        {
            return DbContext.EmployeeCategory.ToList();
        }

        public EmployeeCategory Get(string CategoryName)
        {
            return DbContext.EmployeeCategory.First(x => x.CategoryName == CategoryName);
        }

        public bool Update(int id, string newName)
        {
            try
            {
                var Category = DbContext.EmployeeCategory.First(x => x.Id == id);
                Category.CategoryName = newName;
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Remove(string CategoryName)
        {
            try
            {
                DbContext.EmployeeCategory.Remove(DbContext.EmployeeCategory.First(x => x.CategoryName == CategoryName));
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
