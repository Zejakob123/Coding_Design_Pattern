namespace CodingDesignPattern.src.behavioural.templateMethod
{
    public abstract class CarManufacturingProcess
    {
        // Template method defining the steps of the car manufacturing process
        public void BuildCar()
        {
            AssembleChassis();
            InstallEngine();
            PaintCar();
            AddFeatures();
            FinalInspection();
        }

        // Common steps in car manufacturing (implemented in base class)
        private void AssembleChassis()
        {
            Console.WriteLine("Assembling the chassis...");
        }

        private void PaintCar()
        {
            Console.WriteLine("Painting the car...");
        }

        private void FinalInspection()
        {
            Console.WriteLine("Performing final inspection...");
        }

        // Steps that subclasses will implement
        protected abstract void InstallEngine();
        protected abstract void AddFeatures();
    }
}