namespace CodingDesignPattern.src.behavioural.templateMethod
{
    public class SedanCar : CarManufacturingProcess
    {
        protected override void InstallEngine()
        {
            Console.WriteLine("Installing a 1.5L petrol engine for Sedan...");
        }

        protected override void AddFeatures()
        {
            Console.WriteLine("Adding basic features: AC, radio, cloth seats...");
        }
    }
}