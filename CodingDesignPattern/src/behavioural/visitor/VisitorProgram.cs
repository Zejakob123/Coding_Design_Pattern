namespace CodingDesignPattern.src.behavioural.visitor
{
    public class VisitorProgram
    {
        public void Run()
        {
            List<ICar> cars = new List<ICar>
            {
                new Sedan(),
                new SUV(),
                new SportsCar()
            };

            ICarVisitor maintenanceVisitor = new MaintenanceVisitor();
            ICarVisitor insuranceVisitor = new InsuranceVisitor();

            Console.WriteLine("Applying Maintenance Visitor:");
            foreach (var car in cars)
            {
                car.Accept(maintenanceVisitor);
            }

            Console.WriteLine("\nApplying Insurance Visitor:");
            foreach (var car in cars)
            {
                car.Accept(insuranceVisitor);
            }
        }
    }
}