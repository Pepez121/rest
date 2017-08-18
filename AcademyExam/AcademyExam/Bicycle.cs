using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyExam
{
    public class Bicycle : Vehicle
    {
        public int Pedals { get; set; }

        public override void Move()
        {
            Console.WriteLine("Bicycle moves by human power.");
        }
    }
}
