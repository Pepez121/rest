using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaAbstracta
{
    public abstract class ClaseAbstractaPersona
    {
        public string name { get; set; }
        public DateTime birthDate;

        public abstract void eat();

        public int calcAge()
        {
            int age = DateTime.Now.Year - birthDate.Year;
            return age;
        }
         
    }
}
