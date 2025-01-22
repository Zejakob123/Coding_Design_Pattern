namespace CodingDesignPattern.src.behavioural.strategy
{
    public class SedanDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Sedan: Smooth and comfortable ride.");
        }
    }
}