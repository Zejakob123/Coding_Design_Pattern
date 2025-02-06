namespace CodingDesignPattern.src.structural.bridge
{
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting petrol engine...");
        }
    }
}