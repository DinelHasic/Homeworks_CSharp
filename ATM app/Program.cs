using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3]
           {
              new Customer("Tom","Rose",123123123123,900,200),
              new Customer("Bob", "Tomson", 155155155155, 123,300),
              new Customer("Elizabeth","Flor",144144144144, 330,400)
           };

            while (true)
            {
                Console.WriteLine("Welcome to ATM app");
                Console.WriteLine("Do you want to register or to login enter L (login) or R (register)");
                string op = Console.ReadLine();

                if (op.ToUpper() == "L")
                {
                    double cardNumber = InputCardNumber(customers);

                    int pin = InputPin(customers, cardNumber);

                    Customer customer = FindCustomer(pin, cardNumber, customers);

                    Greating(customer);

                    Options(customer);

                    while (true)
                    {
                        Console.WriteLine("Do you want to do another transaction write y(yes):");
                        string input = Console.ReadLine();

                        if (input.ToLower() == "y")
                        {
                            Options(customer);
                            continue;
                        }
                        break;
                    }
                }
                else if (op.ToUpper() == "R")
                {
                    Register(ref customers);
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                Console.WriteLine("Have a nice day :)");
            }
        }
        static double InputCardNumber(Customer[] customers)
        {
            while (true)
            {
                Console.WriteLine("Please enter your card number:");
                string cardNumber = Console.ReadLine();

                double cardParse = ConvertNumber(cardNumber);

                foreach (Customer customer in customers)
                {
                    if (customer.CardNumber == cardParse)
                        return cardParse;
                }

                Console.WriteLine("Card number invalid!");
            }
        }
        static int InputPin(Customer[] customers, double cardNumber)
        {
            while (true)
            {
                Console.WriteLine("Enter Pin:");
                string numberString = Console.ReadLine();

                int.TryParse(numberString, out int numberParse);

                foreach (Customer customer in customers)
                {
                    if (customer.GetPin() == numberParse && cardNumber == customer.CardNumber)
                        return numberParse;
                }
                Console.WriteLine("Pin invalid!");
            }
        }

        public static Customer FindCustomer(int pin, double cardNumber, Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                if (customer.GetPin() == pin && customer.CardNumber == cardNumber)
                {
                    return customer;
                }
            }

            return null;
        }

        public static void Greating(Customer customer)
        {
            if (customer != null)
            {
                Console.WriteLine($"Welcome {customer.Name} {customer.Surname}");
                return;
            }
            Console.WriteLine("There is a problem with the server :(");
        }
        public static void Options(Customer customer)
        {
            Console.WriteLine("What you like to do:");
            Console.WriteLine("a.Check Balance\nb.Cash Withdrawal\nc.Cash Deposit\nChoose a b or c");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "a":
                    customer.Balance();
                    break;
                case "b":
                    int withdrawAmount = Ammount();
                    customer.WithdrawMoney(withdrawAmount);
                    break;
                case "c":
                    int depositAmount = Ammount();
                    customer.Deposit(depositAmount);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public static int Ammount()
        {
            while (true)
            {
                Console.WriteLine("Enter ammount of money:");
                string numberString = Console.ReadLine();
                if (int.TryParse(numberString, out int numberParse))
                {
                    return numberParse;
                };
                Console.WriteLine("Cant convert words to integer");
            }
        }
        public static double ConvertNumber(string cardNumber)
        {
            string numberString = "";
            foreach (string num in cardNumber.Split('-'))
            {
                numberString += num;
            }
            double.TryParse(numberString, out double numberDouble);
            return numberDouble;
        }
        public static void Register(ref Customer[] customers)
        {
            Console.WriteLine("Enter name:");
            string name = InputString();

            Console.WriteLine("Enter surname");
            string surname = InputString();

            double cardNumber = CheckCardNumber(customers);

            Console.WriteLine("Enter pin:");
            int pinNumber = InputNumber();

            Console.WriteLine("Enter balance:");
            int cashNumber = InputNumber();

            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = new Customer(name, surname, cardNumber, pinNumber, cashNumber);
        }
        public static double CheckCardNumber(Customer[] customers)
        {
            while (true)
            {
                bool duplicate = false;
                Console.WriteLine("Enter card number");
                string numberString = Console.ReadLine();

                if (numberString.Length != 15)
                {
                    Console.WriteLine("Length invalid it shuld contain 12 numbers");
                    continue;
                }

                double cardNumber = ConvertNumber(numberString);

                foreach (Customer customer in customers)
                {
                    if (customer.CardNumber == cardNumber)
                    {
                        Console.WriteLine($"Already contains that card number {customer.CardNumber}");
                        duplicate = true;
                        break;
                    }
                }

                if (!(duplicate))
                {
                    return cardNumber;
                }

            }
        }
        public static int InputNumber()
        {
            while (true)
            {
                string numberString = Console.ReadLine();
                if (!(int.TryParse(numberString, out int numberParse)))
                {
                    Console.WriteLine("Cant convert word to a integer try again:");
                    continue;
                }
                return numberParse;
            }
        }
        public static string InputString()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("The input can not be null.Try again:");
                    continue;
                }
                return input;
            }
        }
    }
}

