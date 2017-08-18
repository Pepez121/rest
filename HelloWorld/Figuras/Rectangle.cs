using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Rectangle : Figuras
    {
        public Rectangle()
        {
            name = "Rectangle";
        }
        //Area = (base x altura) / 2
        //public string name = "Rectangle";
        public override double calcArea(List<int> sideSize)
        {
            return ((sideSize[0] * sideSize[1])/2);
        }
    }
}
