using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>() { 1, 23, 10, 14, 5 };
            var list2 = new List<int>() { 5, 2, 8, 19, 10 };

            var result = from n in list1
                         where !(list2.Contains(n))
                         select n;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            ////numeros1.AddRange(numeros2);
            //var newList = list1.Concat(list2);
            //foreach (var item in newList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("Unión");
            //Unión no repite valores, Intersect muestra los que se repiten
            //var z = list1.Union(list2);
            //foreach (var item in z)
            //{
            //    Console.WriteLine(item);
            //}

            //var listNames = new List<string>() { "cero", "uno", "dos", "tres" };
            //var listNumbers = new List<int>() { 0, 1, 2, 3 };

            //var names = from x in listNumbers
            //            select listNames[x];
            //var names2 = listNames.Select(x => listNumbers[x]);
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Read();
        }
    }
}
