using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //helloWorld();
            //conversion();
            //swapNumbers();
            //displayChar();
            //printArray();
            //printSum();
            //validateAge();
            //findNumber();
            //verifyString();
            //switchStatement();
            tryCatch();
        }

        public static void helloWorld()
        {
            //Lee nombre y lo gaurda en variable name
            Console.WriteLine("Introduce tu nombre: ");
            string name = Console.ReadLine();

            //Lee edad y calcula el año de nacimiento
            Console.WriteLine("¿Cual es tu edad? ");
            int age = int.Parse(Console.ReadLine());
            int year = DateTime.Now.Year - age;

            //Despliega información
            Console.WriteLine("Hola " + name + ", naciste en el año de " + year + ".");
            Console.Read();
        }

        public static void conversion() {
            //Lee temperatura en Fahrenheit
            Console.WriteLine("Introduce tu temepratura en F ");
            double tempF = double.Parse(Console.ReadLine());

            //Calcula temperatura de Fahrenheit a Celcius
            double tempC = (tempF - 32) / 1.8;

            //Despliega información
            Console.WriteLine("La temperatura en Celcius es " + Math.Round(tempC, 2));
            Console.Read();
        }

        public static void swapNumbers()
        {
            //inicializa variables
            short variableA = 10, variableB = 20, cont;

            //Hace operaciones
            cont = variableA;
            variableA = variableB;
            variableB = cont;

            //Muestra resultado en pantalla
            Console.WriteLine("La variable A tiene el valor de " + variableA + " y la variable B tiene el valor de " + variableB);
            Console.Read();
        }

        public static void displayChar()
        {
            //Declaración de arreglo e input de datos
            char[] caracter = new char[3];
            for (int i = 0; i < caracter.Length; i++) {
            Console.WriteLine("Introduce el caracter " + (i+1));
            caracter[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Resultado");

            //Ciclo para imprimir output
            for (int i = caracter.Length - 1; i >= 0; i--) {
                Console.WriteLine(caracter[i]);
            }

            //Método que cambia posición de arreglo en forma inversa
            //Array.Reverse(caracter);
            Console.Read();
        }

        public static void printArray()
        {
            int[] scores = new int[5];
            int[] scores2 = { 2, 3, 5 };
            foreach (int score in scores2)
            {
                Console.WriteLine(score);
            }

            for(int i=0; i<scores.Length; i++)
            {
                scores[i] = i;
            }
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            Console.Read();

        }

        public static void printSum() {
            int suma = 0;
            for(int i = 1; i <= 100; i++)
            {
                suma += i;
            }

            int avg = suma / 100;

            //Imprime resultado
            Console.WriteLine("El total es: " + suma + " y el promedio es " + avg);
            Console.Read();
        }

        public static void validateAge()
        {
            //Lee nombre y lo gaurda en variable name
            Console.WriteLine("Type in your age: ");
            int age = Convert.ToInt16(Console.ReadLine());

            if(age < 18) {
                Console.WriteLine("You are not allowed to drink beer.");
            } else {
                Console.WriteLine("You are allowed to drink a beer.");
            }

            /*
            switch (age)
            {
                case 17:
                    Console.WriteLine("You are a child");
                    break;
                case 18:
                    Console.WriteLine("You are a grown man");
                    break;
                default:
                    Console.WriteLine("I dont know who you are");
                    break;
            }
            */
            Console.Read();
        }

        public static void findNumber() {
            Console.WriteLine("Type in a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = { 13, 53, 64, 2, 4, 49, 500, 32, 29, 90 };
            bool validate = false;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] == num) {
                    validate = true;
                    break;
                }        
            }
            if (validate) {
                Console.WriteLine("The number " + num + " was found inside the array");
            } else {
                Console.WriteLine("The number " + num + " was not found inside the array");
            }

            Console.Read();
        }

        public static void verifyString() {
            string cadena = Console.ReadLine();

            //string pass = age > 20 ? "pass" : "nopass";

            if (string.IsNullOrEmpty(cadena)) {
                Console.WriteLine("The string is empty!");
            } else if (cadena.Length > 5) {
                int index = cadena.IndexOf('a');
                cadena = cadena.Remove(index, 1);
                Console.WriteLine("Output: " + cadena);
            } else {
                int index = cadena.IndexOf('o');
                cadena = cadena.Remove(index, 1);
                Console.WriteLine("Output: " + cadena);
            }
            Console.Read();
        }
         
        public static void tryCatch() {
            int suma = 0;
            int[] array = { 2, 1, 3 };

            try {
                for (int i = 0; i <= array.Length+1; i++)
                {
                    suma += array[i];
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Index out of rage: ");
                Console.WriteLine("Error: " + ex.Message);
            } finally
            {
                Console.WriteLine("End of the program.");
            }

            int avg = suma / 100;

            //Imprime resultado
            Console.WriteLine("El total es: " + suma + " y el promedio es " + avg);
            Console.Read();
        }

    }
}
