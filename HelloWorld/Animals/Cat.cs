using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : IAnimal
    {

        public string name { get; set; }
        private Random rnd = new Random();
        public int Run(int speed)
        {
            int steps = rnd.Next(1, speed);
            return steps;
        }

    
    }
}
