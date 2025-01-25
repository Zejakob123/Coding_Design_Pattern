namespace CodingDesignPattern.src.behavioural.visitor
{
    public class InsuranceVisitor : ICarVisitor
    {
        public void Visit(Sedan sedan)
        {
            Console.WriteLine($"Calculating insurance for {sedan.GetSedanInfo()}");
        }

        public void Visit(SUV suv)
        {
            Console.WriteLine($"Calculating insurance for {suv.GetSUVInfo()}");
        }

        public void Visit(SportsCar sportsCar)
        {
            Console.WriteLine($"Calculating insurance for {sportsCar.GetSportsCarInfo()}");
        }
    }
}