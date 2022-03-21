using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Race
{
    class Driver
    {
        public string Name { get; set; }

        public double Skill { get; set; }

        public Driver()
        {

        }
        public Driver(string name, double skill)
        {
            Name = name;
            Skill = skill;
        }
    }
}
