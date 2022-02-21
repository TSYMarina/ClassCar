using System;

namespace ClassCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "4Runner";
            myCar.Year = 2020;

            Console.WriteLine($"My Car Make is {myCar.Make}.");
            Console.WriteLine($"My Car Model is {myCar.Model}.");
            Console.WriteLine($"My Car Year is {myCar.Year}.");

        }
    }
}
