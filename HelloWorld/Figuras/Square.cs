using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Square : Figuras
    {
        public Square()
        {
            name = "Square";
        }
        //Area = lado x lado
        //public string name = "Square";
        public override double calcArea(List<int> sideSize)
        {
            return Math.Round(Math.Pow(sideSize[0], 2),2);
        }
    }
}
