namespace CodingDesignPattern.src.behavioural.templateMethod
{
    class TemplateMethodProgram
    {
        public void Run()
        {
            Console.WriteLine("Manufacturing a Sedan:");
            CarManufacturingProcess sedan = new SedanCar();
            sedan.BuildCar();

            Console.WriteLine("\nManufacturing a Sports Car:");
            CarManufacturingProcess sportsCar = new SportsCar();
            sportsCar.BuildCar();

            Console.WriteLine("\nManufacturing an SUV:");
            CarManufacturingProcess suv = new SUVCar();
            suv.BuildCar();
        }
    }
}