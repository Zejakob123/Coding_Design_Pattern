using System;

namespace CodingDesignPattern.src.structural.composite
{
    // Leaf - Individual car parts
    public class CarPart : ICarComponent
    {
        private string _name;

        public CarPart(string name)
        {
            _name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Car Part: {_name}");
        }
    }
}
