namespace CodingDesignPattern.src.structural.flyweight
{
    class FlyweightProgram
    {
        public void Run()
        {
            CarFactory carFactory = new CarFactory();

            ICar car1 = carFactory.GetCar("sedan");
            car1.DisplayCar("Red");

            ICar car2 = carFactory.GetCar("suv");
            car2.DisplayCar("Blue");

            ICar car3 = carFactory.GetCar("sedan");
            car3.DisplayCar("Black");

            ICar car4 = carFactory.GetCar("sports");
            car4.DisplayCar("Yellow");

            ICar car5 = carFactory.GetCar("suv");
            car5.DisplayCar("Green");

            Console.WriteLine($"\nTotal unique car objects created: {carFactory.CarsCount()}");
        }
    }
}
