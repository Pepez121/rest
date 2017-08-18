using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyExam
{
    public class Vehicle
    {
        public int Id { get; set; }
        public bool HasEngine { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("Any type of move is valid for a vehicle.");
        }
    }
}
