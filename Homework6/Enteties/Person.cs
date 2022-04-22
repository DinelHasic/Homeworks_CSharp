using Homework.Enum;
namespace Homework.Enteties
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Job { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Job = occupation;
            Dogs = new List<Dog>();
        }

        public override string ToString()
        {
            return $" Name:{FirstName} Surname:{LastName}";
        }
    }
}