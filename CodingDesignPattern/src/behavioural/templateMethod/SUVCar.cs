namespace CodingDesignPattern.src.behavioural.templateMethod
{
    public class SUVCar : CarManufacturingProcess
    {
        protected override void InstallEngine()
        {
            Console.WriteLine("Installing a 2.5L diesel engine for SUV...");
        }

        protected override void AddFeatures()
        {
            Console.WriteLine("Adding off-road features: all-wheel drive, roof rails, larger tires...");
        }
    }
}