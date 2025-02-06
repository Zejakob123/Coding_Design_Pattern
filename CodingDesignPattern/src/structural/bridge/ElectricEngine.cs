namespace CodingDesignPattern.src.structural.bridge
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting electric engine...");
        }
    }
}