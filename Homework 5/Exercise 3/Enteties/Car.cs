using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3.Enteties
{
    class Car
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public Color Color { get; set; }
        public int DistanceTraveled { get; set; }
        public DateTime DateofModel { get; set; }

        public Car(int id, string brandName, string modelName, Color color, int distanceTraveled, DateTime dateofModel)
        {
            Id = id;
            BrandName = brandName;
            ModelName = modelName;
            Color = color;
            DistanceTraveled = distanceTraveled;
            DateofModel = dateofModel;
        }

        public void CalcualtePrice()
        {
            int price = DistanceTraveled * DateofModel.Year / 3;

            Console.WriteLine($" The price of the car: {price}$");
        }
    }
}
