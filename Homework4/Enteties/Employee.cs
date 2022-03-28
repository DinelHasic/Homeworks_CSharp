using System;

namespace Enteties
{
    public class Employee
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
       
        public Role Role { get; set; }

        protected double Salary;


        public Employee()
        {

        }
        public Employee(string name, string surname, Role role, double salary)
        {
            FisrtName = name;
            LastName = surname;
            Role = role;
            Salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{FisrtName} {LastName} Salary:{Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
