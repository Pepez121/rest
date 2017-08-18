using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.data;

namespace UniversityConsole
{
    class OfficeRepository
    {
        private DbUniversity DbContext = new DbUniversity();

        public bool Add(int building, int  floor)
        {
            try
            {
                var Office = new Office() { Building = building, FloorNumber = floor };
                DbContext.Office.Add(Office);
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Office> Get()
        {
            return DbContext.Office.ToList();
        }

        public Office Get(int building)
        {
            return DbContext.Office.First(x => x.Building == building);
        }

        public bool Update(int id, int floor)
        {
            try
            {
                var office = DbContext.Office.First(x => x.Id == id);
                office.FloorNumber = floor;
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Remove(int building)
        {
            try
            {
                DbContext.Office.Remove(DbContext.Office.First(x => x.Building == building));
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
