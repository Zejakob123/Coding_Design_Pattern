namespace CodingDesignPattern.src.behavioural.templateMethod
{
    public class SportsCar : CarManufacturingProcess
    {
        protected override void InstallEngine()
        {
            Console.WriteLine("Installing a V8 twin-turbo engine for Sports Car...");
        }

        protected override void AddFeatures()
        {
            Console.WriteLine("Adding luxury features: leather seats, premium sound system, sunroof...");
        }
    }
}