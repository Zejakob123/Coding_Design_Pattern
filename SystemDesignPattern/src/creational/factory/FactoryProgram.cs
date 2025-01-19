// File1.cs
namespace SystemDesignPattern.src.creational.factory
{
    public class FactoryProgram
    {
        public void Run()
        {
            Console.WriteLine("Enter car type (sedan, suv, sports): ");
            string carType = Console.ReadLine();
            Console.WriteLine($"You selected {carType}.");

            try
            {
                ICar car = CarFactory.CreateCar(carType);
                car.Drive();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
