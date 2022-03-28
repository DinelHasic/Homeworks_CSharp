using Enteties;
using System;
namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager manager1 = new Manager("Dinel", "Hasic", "Contract Menager");
            Manager manager2 = new Manager("Will", "Smith", "Accounting Manager");

            manager1.AddBonus(1300);
            Console.WriteLine($"{manager1.FisrtName} Salary:{manager1.GetSalary()}");

            Contracter contracter1 = new Contracter("Tom", "Holand", 14, 7, manager1);
            Contracter contracter2 = new Contracter("Elizabeth", "Brown", 15, 8, manager1);

            Console.WriteLine($"{contracter1.Role} {contracter1.FisrtName} Salary:{contracter1.GetSalary()}");
            Console.WriteLine(contracter1.CurentPosition());

            SalesPerson salesperson = new SalesPerson("Juli", "Fot");

            salesperson.PrintInfo();

            Employee[] employees = new Employee[] { manager1, manager2, contracter1, contracter2, salesperson };

            CEO ceo = new CEO("Steve", "Jobs", 2000, employees);

            ceo.AddSharePrice(30);
            Console.WriteLine($"CEO salary:{ceo.GetSalary()}");

            ceo.PrintEmployee();
           
           

        }
    }

}
