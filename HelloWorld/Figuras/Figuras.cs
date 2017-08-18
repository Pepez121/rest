using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public abstract class Figuras
    {
        public string name;
        public abstract double calcArea(List<int> sideSize);

        public void printName()
        {
            Console.WriteLine("Type of figure: " + name);
        }

    }
}
