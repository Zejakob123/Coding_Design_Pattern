namespace CodingDesignPattern.src.behavioural.strategy
{
    public class StrategyProgram
    {
        public void Run()
        {
            // Initialize with a Sedan drive strategy
            Car myCar = new Car(new SedanDriveStrategy());
            Console.WriteLine("Initial Strategy:");
            myCar.Drive();

            // Change to SUV drive strategy
            Console.WriteLine("\nSwitching to SUV Strategy:");
            myCar.SetDriveStrategy(new SUVDriveStrategy());
            myCar.Drive();

            // Change to Sports Car drive strategy
            Console.WriteLine("\nSwitching to Sports Car Strategy:");
            myCar.SetDriveStrategy(new SportsCarDriveStrategy());
            myCar.Drive();
        }
    }
}