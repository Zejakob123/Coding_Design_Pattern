namespace CodingDesignPattern.src.behavioural.strategy
{
    public class SUVDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Driving an SUV: Perfect for off-road and rough terrains.");
        }
    }
}