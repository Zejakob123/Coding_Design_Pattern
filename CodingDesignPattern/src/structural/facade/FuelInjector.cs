namespace CodingDesignPattern.src.structural.facade
{
    public class FuelInjector
    {
        public void Inject()
        {
            Console.WriteLine("Fuel injected.");
        }

        public void ShutOff()
        {
            Console.WriteLine("Fuel injector shut off.");
        }
    }
}
