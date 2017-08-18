using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaAbstracta
{
    class ClasePersonaVegetariana : ClaseAbstractaPersona
    {
        public override void eat()
        {
            Console.WriteLine(name + " come menu para vegetarianos.");
        }
    }
}
