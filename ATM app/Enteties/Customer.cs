using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double CardNumber { get; set; }

        private int Pin;

        private int Cash;

        public Customer(string name, string surname, double cardNumber, int pin, int cash)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            Pin = pin;
            Cash = cash;
        }

        public int GetPin()
        {
            int pin = Pin;
            return pin;
        }
        public void Balance()
        {
            Console.WriteLine($"Current money in your bank accaunt:{Cash}$");
        }
        public void WithdrawMoney(int amount)
        {
            if (amount > Cash)
            {
                Console.WriteLine("You don't have enough money");
            }
            else
            {
                Cash = Cash - amount;
                Console.WriteLine($"You withdraw money {amount}$ You have {Cash}$ left on your account.");
            }
        }
        public void Deposit(int amount)
        {
            Cash = Cash + amount;
            Console.WriteLine($"You have deposited {amount}$ New balance is {Cash}$");
        }
    }
}