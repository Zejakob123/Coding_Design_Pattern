namespace CodingDesignPattern.src.structural.flyweight
{
    public class Sedan : ICar
    {
        public void DisplayCar(string color)
        {
            Console.WriteLine($"Sedan Car in {color} color.");
        }
    }

    public class SUV : ICar
    {
        public void DisplayCar(string color)
        {
            Console.WriteLine($"SUV Car in {color} color.");
        }
    }

    public class SportsCar : ICar
    {
        public void DisplayCar(string color)
        {
            Console.WriteLine($"Sports Car in {color} color.");
        }
    }
}
