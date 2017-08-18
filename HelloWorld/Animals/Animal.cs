using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string name { get; set; }

        public abstract int Run(); //Est se define en la sub clase
        public virtual void Speak()
        {
            Console.WriteLine("Hello");
        }

        //Overload
        public virtual void Speak(string language)
        {
            Console.WriteLine(language);
        }
    }
}
