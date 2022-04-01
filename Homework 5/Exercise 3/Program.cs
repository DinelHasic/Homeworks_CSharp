using Exercise_3.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(1111,"Mercedes-Benz", "A-Class",Color.Black,10000,new DateTime(2021,1,12)),
                new Car(3333,"Audi", "A3",Color.Green,50000,new DateTime(2022,1,3)),
                new Car(2222,"Audi", "A6",Color.Black,40000,new DateTime(2022,2,5)),
                new Car(5555,"Ford", "Fiesta",Color.Red,120000,new DateTime(2017,5,15)),
                new Car(3333,"Ford", "Focus",Color.Black,40000,new DateTime(2019,8,7)),
                new Car(444,"Hyundai", "Accent",Color.Red,130000,new DateTime(2015,9,21)),
            };


            Console.WriteLine("The price of cars with color red:");
            List<Car> carsRed = cars.Where(c => c.Color == Color.Red).ToList();
            carsRed.ForEach(c => c.CalcualtePrice());

            Console.WriteLine("The price of cars with brand name Ford:");
            List<Car> carsFord = cars.Where(c => c.BrandName == "Ford").ToList();
            carsFord.ForEach(c => c.CalcualtePrice());

            Console.WriteLine("Cars that have traveled less then 100,000KM:");
            List<Car> carsDistance = cars.Where(c => c.DistanceTraveled < 100000).ToList();
            carsDistance.ForEach(c => Console.WriteLine($" Car:{c.ModelName} {c.BrandName} Color: {c.Color} Created:{c.DateofModel}"));


        }
    }
}
