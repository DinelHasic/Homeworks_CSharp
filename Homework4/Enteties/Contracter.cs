using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class Contracter : Employee
    {
        public double WorkHour { get; set; }
        public double PayPerHour { get; set; }
        public Manager Responsible { get; set; }


        public Contracter(string name, string surname, double payPerHour, double workHour,Manager responsible) : base(name, surname, Role.Contacter, 0)
        {
            FisrtName = name;
            LastName = surname;
            PayPerHour = payPerHour;
            WorkHour = workHour;
            Responsible = responsible;
        }
        public override double GetSalary()
        {
            Salary = WorkHour * PayPerHour;
            return Salary;
        }
        public string CurentPosition()
        {
            return $"{Responsible.FisrtName} is {Responsible.Department} is responsible for {FisrtName}";
        }
    }
}
