using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptiles : Animals
    {
        public string name { get; set; }
        public string scaleColor { get; set; }
        public bool isPoison { get; set; } = false;
        public bool isDangerous { get; set;} = false;

        public void PleasePrint()
        {
            Console.WriteLine($"Name: {name}\n" +
                              $"Scale Color:{scaleColor}\n" +
                              $"Poisonous?: {isPoison}\n" +
                              $"Dangerous?: {isDangerous}");
        }
    }
}
