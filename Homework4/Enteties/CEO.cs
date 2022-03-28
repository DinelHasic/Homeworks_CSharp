using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice;

        public CEO(string name,string surname,int shares,Employee[] employees):base(name,surname,Role.CEO,2000)
        {
            Shares = shares;
            this.Employees = employees;
        }
        public void AddSharePrice(double number)
        {
            _sharesPrice = number;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Employess:");
            foreach (Employee employe in this.Employees)
            {
                Console.WriteLine($"Name: {employe.FisrtName} Surname:{employe.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * _sharesPrice;
        }

    }
}
