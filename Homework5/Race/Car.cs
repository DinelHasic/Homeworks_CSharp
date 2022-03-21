using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Race
{
    class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }

        public Car()
        {

        }
        public Car(string model, double speed)
        {
            Model = model;
            Speed = speed;
        }
        public double CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }

    }
}
