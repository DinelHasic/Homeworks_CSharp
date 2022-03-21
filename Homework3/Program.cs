using Homework3.Race;
using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4] { new Car("Hyundai", 280), new Car("Mazda", 270), new Car("Ferrari", 320), new Car("Porsche", 300) };
            Driver[] drivers = new Driver[4] { new Driver("Bob", 75), new Driver("Greg", 53), new Driver("Jill", 62), new Driver("Anne", 80) };

            while (true)
            {
                Console.WriteLine("Car number one");
                Car carOne = getCar(cars);
                carOne.Driver = getDriver(drivers);


                Console.WriteLine("Car number two");
                Car carTwo = getCar(cars);
                carTwo.Driver = getDriver(drivers);

                RaceCars(carOne, carTwo);

                Console.WriteLine("Do you want to race again y/n:");
                string input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    continue;
                }
                break;
            }
        }
        public static Car getCar(Car[] cars)
        {

            foreach (Car car in cars)
                Console.WriteLine($"*{car.Model} \n");

            Console.WriteLine("Choose a car from the above::");
            while (true)
            {
                string carModel = Console.ReadLine();

                foreach (Car car in cars)
                {
                    if (car.ModelToLower() == carModel.ToLower())
                    {
                        return car;
                        break;
                    }
                }
                Console.WriteLine("Wrong input try again:");
            }
        }

        public static Driver getDriver(Driver[] drivers)
        {
            foreach (Driver driver in drivers)
                Console.WriteLine($"* {driver.Name} \n");

            Console.WriteLine("Choose a driver from the above:");
            while (true)
            {
                string driverName = Console.ReadLine();
                foreach (Driver driver in drivers)
                {
                    if (driver.Name.ToLower() == driverName.ToLower())
                    {
                        return driver;
                        break;
                    }
                }
                Console.WriteLine("Wrong input try again:");
            }
        }

        public static void RaceCars(Car carOne, Car carTwo)
        {
            if (carOne.CalculateSpeed() >= carTwo.CalculateSpeed())
            {
                Console.WriteLine($"{carOne.Model} won the race.Speed:{carOne.Speed}km/h. Driver:{carOne.Driver.Name}");
            }
            else
            {
                Console.WriteLine($"{carTwo.Model} won the race.Speed:{carTwo.Speed}km/h. Driver:{carTwo.Driver.Name}");
            }
        }
    }
}
