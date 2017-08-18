using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {

            ClaseAbstractaPersona diabetico = new ClasePersonaDiabetica();
            diabetico.name = "Joel";
            diabetico.birthDate = new DateTime(2002, 12, 12);
            Console.WriteLine("El diabetico se llama " + diabetico.name + ", tiene " + diabetico.calcAge() + " años.");
            diabetico.eat();


            ClaseAbstractaPersona vegetariano = new ClasePersonaVegetariana();
            vegetariano.name = "Luis";
            vegetariano.birthDate = new DateTime(1993, 12, 12);
            Console.WriteLine("El vegetariano se llama " + vegetariano.name + " y tiene " + vegetariano.calcAge() + " años.");
            vegetariano.eat();
            Console.Read();
        }
    }
}
