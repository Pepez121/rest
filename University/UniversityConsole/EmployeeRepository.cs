using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.data;

namespace UniversityConsole
{
    public class EmployeeRepository
    {
        private DbUniversity DbContext = new DbUniversity();
        public bool Add(string firstName, string lastName, int hours, string enrollment, int officeId, int employeeCategoryId )
        {
            try
            {
                var Employee = new Employee() {
                    FirstName = firstName,
                    LastName = lastName,
                    Enrollment = enrollment,
                    OfficeId = officeId,
                    EmployeeCategoryId = employeeCategoryId
                };
                DbContext.Employee.Add(Employee);
                DbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Employee> Get()
        {
            return DbContext.Employee.ToList();
        }

        public Employee Get(string enr)
        {
            //return DbContext.Student.Where(x => x.Enrollment == enr).First();
            return DbContext.Employee.First(x => x.Enrollment == enr);
        }

        public bool Update(int id, string newName)
        {
            try
            {
                var Employee = DbContext.Employee.First(x => x.Id == id);
                Employee.LastName = newName;
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Remove(string enr)
        {
            try
            {
                DbContext.Employee.Remove(DbContext.Employee.First(x => x.Enrollment == enr));
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool AddOffice(int deptID, int employeeID)
        {
            try
            {
                var employee = DbContext.Employee.First(s => s.Id == employeeID);
                var dept = DbContext.Department.First(c => c.Id == deptID);
                if ((dept != null) && (employee != null))
                {
                    employee.Departments.Add(dept);
                    DbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool RemoveCourse(int deptID, int employeeID)
        {
            try
            {
                var employee = DbContext.Employee.First(s => s.Id == employeeID);
                var dept = DbContext.Department.First(c => c.Id == deptID);
                if ((dept != null) && (employee != null))
                {
                    employee.Departments.Remove(dept);
                    DbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public int TotalEmployees()
        {
            return DbContext.Employee.Count();
        }

        public void Print()
        {
            foreach (var obj in DbContext.Employee.ToList())
            {
                Console.WriteLine("ID: " + obj.Id);
                Console.WriteLine("First Name = " + obj.FirstName);
                Console.WriteLine("Last Name = " + obj.LastName);
                Console.WriteLine("Enrollment = " + obj.Enrollment);
                Console.WriteLine("Hours per day = " + obj.Hours);
                Console.WriteLine("Office = " + ((obj.OfficeId == null) ? "None assigned yet" : Convert.ToString(obj.OfficeId)));
                Console.WriteLine("Category = " + obj.EmployeeCategoryId);
                int n = 1;
                foreach (var item in obj.Departments)
                {
                    Console.WriteLine("Department " + n + " = " + item.Name);
                    n++;
                }
                Console.WriteLine("\n");
            }
        }
        public void Print(int id)
        {
            var obj = DbContext.Employee.First(x => x.Id == id);
            Console.WriteLine("ID: " + obj.Id);
            Console.WriteLine("First Name = " + obj.FirstName);
            Console.WriteLine("Last Name = " + obj.LastName);
            Console.WriteLine("Enrollment = " + obj.Enrollment);
            Console.WriteLine("Hours per day = " + obj.Hours);
            Console.WriteLine("Office = " + ((obj.OfficeId == null) ? "None assigned yet" : Convert.ToString(obj.Office)));
            Console.WriteLine("Category = " + obj.EmployeeCategory);
            int n = 1;
            foreach (var item in obj.Departments)
            {
                Console.WriteLine("Department " + n + " = " + item.Name);
                n++;
            }
            Console.WriteLine("\n");
        }


    }
}
