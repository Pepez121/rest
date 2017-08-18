using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.data;

namespace UniversityConsole
{
    public class DepartmentRepository
    {
        private DbUniversity DbContext = new DbUniversity();

        public bool Add(string name)
        {
            try
            {
                var Department = new Department() { Name = name };
                DbContext.Department.Add(Department);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Department> Get()
        {
            return DbContext.Department.ToList();
        }

        public Department Get(string name)
        {
            return DbContext.Department.First(x => x.Name == name);
        }

        public bool Update(int id, string newName)
        {
            try
            {
                var department = DbContext.Department.First(x => x.Id == id);
                department.Name = newName;
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Remove(string name)
        {
            try
            {
                DbContext.Department.Remove(DbContext.Department.First(x => x.Name == name));
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void Print()
        {
            foreach (var obj in DbContext.Department.ToList())
            {
                Console.WriteLine("ID: " + obj.Id);
                Console.WriteLine("Department Name = " + obj.Name);
                int n = 1;
                foreach (var item in obj.Employees)
                {
                    Console.WriteLine("Teacher " + n + " = " + item.FirstName + " " + item.LastName + " [" + item.Enrollment + "]");
                    n++;
                }
                Console.WriteLine("\n");
            }
        }
        public void Print(int id)
        {
            var obj = DbContext.Department.First(x => x.Id == id);
            Console.WriteLine("ID: " + obj.Id);
            Console.WriteLine("Department Name = " + obj.Name);
            int n = 1;
            foreach (var item in obj.Employees)
            {
                Console.WriteLine("Teacher " + n + " = " + item.FirstName + " " + item.LastName + " [" + item.Enrollment + "]");
                n++;
            }
            Console.WriteLine("\n");
        }


    }
}
