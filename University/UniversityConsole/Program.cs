using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.data;

namespace UniversityConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var Student = new StudentRepository();
            var Course = new CourseRepository();
            var EmployeeCategory = new EmployeeCategoryRepository();
            var Employee = new EmployeeRepository();
            var Department = new DepartmentRepository();
            var Office = new OfficeRepository();

            Employee.Print();

            Console.Read();
        }
    }
}
