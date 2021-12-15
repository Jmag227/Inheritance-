using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Birds : Animals
    {
        public Birds(String Name, string Color, bool Fly, bool Eat)
        {
            name = Name;
            color = Color;
            canFly = Fly;
            normalToEat = Eat;
        }
        public string name { get; set; }
        public string color { get; set; }
        public bool canFly { get; set; } = false;
        public bool normalToEat { get; set; } = false;

        public void PleasePrint()
        {
            Console.WriteLine($"Name: {name}\n" +
                              $"Color:{color}\n" +
                              $"Can it fly?: {canFly}\n" +
                              $"Should we eat it?: {normalToEat}");
        }

    }
}
