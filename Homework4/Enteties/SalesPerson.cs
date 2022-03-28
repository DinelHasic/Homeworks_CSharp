using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue;

        public SalesPerson()
        {

        }
        public SalesPerson(string name, string surname):base(name,surname,Role.Sales,500)
        {

        }

        public void AddSucessSaleRevenue(double number)
        {
            _successSaleRevenue = number;
        }

        public override double GetSalary()
        {
            double bonus = 0;

            if (_successSaleRevenue <= 2000)
                bonus = 500;
            if (_successSaleRevenue > 2000 || _successSaleRevenue <= 5000)
                bonus = 1000;
            if (_successSaleRevenue > 5000)
                bonus = 1500;

            return Salary + bonus;
        }
    }
}
