using System;

namespace classEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();

            firstCar.Make = "Toyota";
            firstCar.Model = "Rav4";
            firstCar.Year = 2020;

            Console.WriteLine($"My car is a {firstCar.Year} {firstCar.Make} {firstCar.Model}.");
        }
    }
}

