using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreateOn { get; set; }

        public User(int id, string firstName, string lastName, DateTime createOn)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreateOn = createOn;
        }
    }
}
