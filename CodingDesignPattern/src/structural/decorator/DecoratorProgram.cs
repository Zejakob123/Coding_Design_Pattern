using System;
using CodingDesignPattern.src.structural.decorator;

class DecoratorProgram
{
    public void Run()
    {
        // Basic Car
        ICar basicCar = new BasicCar();
        Console.WriteLine($"{basicCar.GetDescription()} costs {basicCar.GetCost()}");

        // Basic Car with GPS
        ICar gpsCar = new GPSDecorator(new BasicCar());
        Console.WriteLine($"{gpsCar.GetDescription()} costs {gpsCar.GetCost()}");

        // Basic Car with GPS and Sound System
        ICar luxuryCar = new SoundSystemDecorator(new GPSDecorator(new BasicCar()));
        Console.WriteLine($"{luxuryCar.GetDescription()} costs {luxuryCar.GetCost()}");
    }
}
