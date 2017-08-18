using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle
            Figuras circulo = new Circle();
            //circulo.name = "Circle";
            circulo.printName();
            Console.WriteLine("Insert radius value: ");
            var radiusList = new List<int>();
            radiusList.Add(Convert.ToInt16(Console.ReadLine()));
            double circleArea = circulo.calcArea(radiusList);
            Console.WriteLine("The circle's area is " + circleArea);

            //Rectangle
            Figuras rectangulo = new Rectangle();
            //rectangulo.name = "Rectangle";
            rectangulo.printName();
            var rectangleList = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Insert side " + (i+1) + " lenght: ");
                rectangleList.Add(Convert.ToInt16(Console.ReadLine()));
            }
            double rectangleArea = rectangulo.calcArea(rectangleList);
            Console.WriteLine("The rectangle's area is " + rectangleArea);

            //Square
            Figuras cuadrado = new Square();
            //cuadrado.name = "Square";
            cuadrado.printName();
            Console.WriteLine("Insert side length: ");
            var squareList = new List<int>();
            squareList.Add(Convert.ToInt16(Console.ReadLine()));
            double squareArea = cuadrado.calcArea(squareList);
            Console.WriteLine("The square's area is " + squareArea);
            Console.Read();
        }
    }
}
