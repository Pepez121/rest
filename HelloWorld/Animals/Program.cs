using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //animal.Speak();
            //animal.name = "animal";
            //Console.WriteLine("The animal's name is " + animal.name);

            //Polimorfismo
            //Animal dog2 = new Dog();
            //dog2.Speak();

            //Herencia

            //Llama método Speak, y cambia y despliega nombre de objeto
            //Dog dog = new Dog();
            //dog.Speak();
            //dog.name = "perrito";
            //Console.WriteLine("The dog's name is " + dog.name);

            //Llama método Speak, y cambia y despliega nombre de objeto
            //Cat cat = new Cat();
            //cat.Speak();
            //cat.name = "gatito";
            //Console.WriteLine("The cat's name is " + cat.name);
            //Console.WriteLine("Number of steps: " + numberOfSteps);

            //Llama método Speak, y cambia y despliega nombre de objeto
            //Duck duck = new Duck();
            //duck.Speak();
            //duck.name = "patito";
            //Console.WriteLine("The duck's name is " + duck.name);

            Cat cat = new Cat();
            int catSteps = 0;

            Dog dog = new Dog();
            int dogSteps = 0;

            Duck duck = new Duck();
            int duckSteps = 0;
            int i = 1;

            while((dogSteps < 100) && (duckSteps < 100) && (catSteps < 100))
            {
                //Muestra en qué vuelta están
                Console.WriteLine("Loop: " + i);

                //Se suman los pasos de cada animal
                Console.WriteLine("Number of cat steps: " + catSteps);
                catSteps += cat.Run(20);
                Console.WriteLine("Number of dog steps: " + dogSteps);
                dogSteps += dog.Run(19);
                Console.WriteLine("Number of duck steps: " + duckSteps);
                duckSteps += duck.Run(18);
                i++;
            }
            //do
            //{
            //    //Muestra en qué vuelta están
            //    Console.WriteLine("Loop: " + i);

            //    //Se suman los pasos de cada animal
            //    Console.WriteLine("Number of cat steps: " + catSteps);
            //    catSteps += cat.Run(20);
            //    Console.WriteLine("Number of dog steps: " + dogSteps);
            //    dogSteps += dog.Run(19);
            //    Console.WriteLine("Number of duck steps: " + duckSteps);
            //    duckSteps += duck.Run(18);
            //    i++;
            //} while ((dogSteps < 100) && (duckSteps < 100) && (catSteps < 100));

            

            Console.Read();

        }
    }
}
