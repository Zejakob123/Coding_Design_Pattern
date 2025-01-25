namespace CodingDesignPattern.src.behavioural.visitor
{
    public class MaintenanceVisitor : ICarVisitor
    {
        public void Visit(Sedan sedan)
        {
            Console.WriteLine($"Performing maintenance on {sedan.GetSedanInfo()}");
        }

        public void Visit(SUV suv)
        {
            Console.WriteLine($"Performing maintenance on {suv.GetSUVInfo()}");
        }

        public void Visit(SportsCar sportsCar)
        {
            Console.WriteLine($"Performing maintenance on {sportsCar.GetSportsCarInfo()}");
        }
    }
}