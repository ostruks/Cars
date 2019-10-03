using MyOwnCollection;
using System;

namespace MyCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();

            cars.AddCar(new Car("BMW", "X5", 2.8));
            cars.AddCar(new Car("MAZDA", "CX5", 2.4));
            cars.AddCar(new Car("ZAZ", "Forsa", 1.4));

            foreach(var a in cars.GetCars())
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
