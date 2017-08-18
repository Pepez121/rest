using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Circle : Figuras
    {
        public Circle()
        {
            name = "Circle";
        }

        //Area = PI x radio^2
        double pi = Math.PI;
        //public string name = "Circle";
        public override double calcArea(List<int> sideSize)
        {
            return Math.Round((Math.Pow(sideSize[0], 2) * pi),2) ;
        }
    }
}
