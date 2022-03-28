using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class Manager:Employee
    {

        public string Department;
        private double _bonus;

        public Manager(string name, string surname,string department):base(name,surname,Role.Manager,1000)
        {
            Department = department;
        }

        public void AddBonus(double bonus)
        {
            _bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
