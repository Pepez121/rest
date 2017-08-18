using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.data;

namespace UniversityConsole
{
    public class StudentRepository
    {
        private DbUniversity DbContext = new DbUniversity();
        public bool Add(string fName, string lName, int enr)
        {
            try
            {
                var Student = new Student() { FirstName = fName, LastName = lName, Enrollment = enr };
                DbContext.Student.Add(Student);
                DbContext.SaveChanges();
                
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Student> Get()
        {
            return DbContext.Student.ToList();
        }

        public Student Get(int enr)
        {
            //return DbContext.Student.Where(x => x.Enrollment == enr).First();
            return DbContext.Student.First(x => x.Enrollment == enr);
        }

        public bool Update(int id, string newName)
        {
            try
            {
                var student = DbContext.Student.First(x => x.Id == id);
                student.LastName = newName;
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Remove(int enr)
        {
            try
            {
                DbContext.Student.Remove(DbContext.Student.First(x => x.Enrollment == enr));
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool AddCourse(int studentID, int courseID)
        {
            try
            {
                var student = DbContext.Student.First(s => s.Id == studentID);
                var course = DbContext.Course.First(c => c.Id == courseID);
                if ((student != null) && (course != null))
                {
                    student.Courses.Add(course);
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

        public bool RemoveCourse(int studentID, int courseID)
        {
            try
            {
                var student = DbContext.Student.First(s => s.Id == studentID);
                var course = DbContext.Course.First(c => c.Id == courseID);
                if ((student != null) && (course != null))
                {
                    student.Courses.Remove(course);
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

        public int TotalStudents()
        {
            return DbContext.Student.Count();
        }

        public void Print()
        {
            foreach (var obj in DbContext.Student.ToList())
            {
                Console.WriteLine("ID: " + obj.Id);
                Console.WriteLine("First Name = " + obj.FirstName);
                Console.WriteLine("Last Name = " + obj.LastName);
                Console.WriteLine("Enrollment = " + obj.Enrollment);
                int n = 1;
                foreach (var item in obj.Courses)
                {
                    Console.WriteLine("Course " + n + " = " + item.Name + " (" + item.Credits + " credits)");
                    n++;
                }
                Console.WriteLine("\n");
            }
        }
        public void Print(int id)
        {
            var obj = DbContext.Student.First(x => x.Id == id);
            Console.WriteLine("ID: " + obj.Id);
            Console.WriteLine("First Name = " + obj.FirstName);
            Console.WriteLine("Last Name = " + obj.LastName);
            Console.WriteLine("Enrollment = " + obj.Enrollment);
            int n = 1;
            foreach (var item in obj.Courses)
            {
                Console.WriteLine("Course " + n + " = " + item.Name + " (" + item.Credits + " credits)");
                n++;
            }
            Console.WriteLine("\n");
        }
    }
}
