using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.data;

namespace UniversityConsole
{
    public class CourseRepository
    {
        private DbUniversity DbContext = new DbUniversity();
        public bool Add(string name, int credits)
        {
            try
            {
                var course = new Course() { Name = name, Credits = credits };
                DbContext.Course.Add(course);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public List<Course> Get()
        {
            return DbContext.Course.ToList();
        }

        public Course Get(string name)
        {
            //return DbContext.Student.Where(x => x.Enrollment == enr).First();
            return DbContext.Course.First(x => x.Name == name);
        }
        public bool Update(int id, string newName)
        {
            try
            {
                var course = DbContext.Course.First(x => x.Id == id);
                course.Name = newName;
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
                DbContext.Course.Remove(DbContext.Course.First(x => x.Name == name));
                DbContext.SaveChanges();
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
