using System;
using System.Collections.Generic;
using System.Threading;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User(1223, "Dinel", "Hasic", new DateTime(2021,2,11,12,22,1)),
                new User(1222, "Elizabeth", "Brown", new DateTime(2022, 1, 12,14,23,2)),
                new User(1111, "Wiliam", "Princ", new DateTime(2020,5,7,9,32,43))
            };

            Dictionary<int, User> dictionaryUsers = new Dictionary<int, User>();

            users.ForEach(n => dictionaryUsers.Add(n.Id, n));

            while (true)
            {
                Console.WriteLine("Enter S(search) or R(register):");
                string input = Console.ReadLine();

                if (input.ToLower() == "s")
                {
                    Console.WriteLine("Enter id to find user:");
                    int search = InputNumber();
                    if (dictionaryUsers.ContainsKey(search))
                    {
                        User user = dictionaryUsers[search];

                        Console.WriteLine($"User:{user.FirstName} {user.LastName} Date: {user.CreateOn}");
                    }
                    else
                    {
                        Console.WriteLine("Value not found :(");
                    }
                }

                if (input.ToLower() == "r")
                {
                    Console.Clear();
                    Console.WriteLine("Registering");


                    Console.Write("Enter first name:");
                    string name = InputString();

                    Console.Write("Enter last name:");
                    string surname = InputString();

                    int id = 0;
                    do
                    {
                        Console.WriteLine("Enter id:");
                        id = InputNumber();
                    } while (dictionaryUsers.ContainsKey(id));

                    dictionaryUsers.Add(id, new User(id, name, surname, DateTime.Now));

                    Console.WriteLine("Loading.....");
                    Thread.Sleep(1000);
                    Console.WriteLine("Registretion Compleate :)");
                }

            }
        }
        public static int InputNumber()
        {
            string numberString = Console.ReadLine();

            int.TryParse(numberString, out int numberParse);

            return numberParse;
        }

        public static string InputString()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input.Length > 255) Console.WriteLine("The max lenght is 255 Input again:");

                else return input;
            }
        }
    }
}

