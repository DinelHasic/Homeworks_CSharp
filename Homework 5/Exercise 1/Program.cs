using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            while (true)
            {
                int number = InputNumber();
                numbers.Enqueue(number);

                Console.WriteLine("Do you want to conitinue write Y(yes)/N(no):");
                string check = Console.ReadLine();

                if (check.ToLower() == "y") continue;

                if (check.ToLower() == "n" || check.ToLower() != "y") break;
            }


            while (numbers.Count != 0)
            {
                numbers.TryDequeue(out int number);
                Console.WriteLine(number);
            }
        }
        public static int InputNumber()
        {
            Console.WriteLine("Enter a number:");
            string numberString = Console.ReadLine();

            int.TryParse(numberString, out int numberParse);

            return numberParse;
        }
    }
}
