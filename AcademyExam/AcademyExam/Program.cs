using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyExam
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var Program = new Program();
            //Program.GetTodaysDate();
            //Program.CreateSomeVehicles();
            //Program.SoftMyVehices();
            GetTodaysDate();
            CreateSomeVehicles();
            SoftMyVehices();
            Console.Read();
        }

        private static void GetTodaysDate()
        {
            string day = Convert.ToString(System.DateTime.Now.DayOfWeek);
            Console.WriteLine("Today is: " + day);
        }

        private static void CreateSomeVehicles()
        {
            var Vehicle = new Vehicle() { Id = 0,  HasEngine = true, Name = "Airplane", Color = "White"};
            var Car = new Car() { Id = 0, HasEngine = true, Name = "Ferrari",  Color = "Red", Doors = 2};
            var Bike = new Bicycle() { Id = 0, HasEngine = false, Name = "Apache", Color = "Blue", Pedals = 2 };
            Vehicle.Move();
            Car.Move();
            Bike.Move();
            //Console.WriteLine("ID: " + Vehicle.Id + ", Engine: " + Vehicle.HasEngine + ", Name: " + Vehicle.Name + ", Color: " + Vehicle.Color);
            //Console.WriteLine("ID: " + Car.Id + ", Engine: " + Car.HasEngine + ", Name: " + Car.Name + ", Color: " + Car.Color + ", Doors: " + Car.Doors);
            //Console.WriteLine("ID: " + Bike.Id + ", Engine: " + Bike.HasEngine + ", Name: " + Bike.Name + ", Color: " + Bike.Color + ", Pedals: " + Bike.Pedals);
        }
        
        private static void SoftMyVehices()
        {
            var VehiclesList = new List<Vehicle>();
            var rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                var Car = new Car() { Id = rnd.Next(1, 10), HasEngine = true };
                VehiclesList.Add(Car);
            }
            for (int i = 0; i < 3; i++)
            {
                var Bike = new Bicycle() { Id = rnd.Next(1, 10), HasEngine = false };
                VehiclesList.Add(Bike);
            }

            var VehicleIdList = from x in VehiclesList
                                orderby x.Id
                                select x.Id;

            var CarMaxIdList = from x in VehiclesList
                               where x.HasEngine == true
                               select x.Id;

            var BicycleMaxIdList = from x in VehiclesList
                                   where x.HasEngine == false
                                   select x.Id;

            foreach (var item in VehicleIdList)
            {
                Console.WriteLine("ID: " + item);
            }
            Console.WriteLine("Max Car ID: " + CarMaxIdList.Max());
            Console.WriteLine("Max Bicycle ID: " + BicycleMaxIdList.Max());
        }

    }
}
