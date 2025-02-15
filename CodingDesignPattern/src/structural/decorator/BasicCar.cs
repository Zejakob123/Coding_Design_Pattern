namespace CodingDesignPattern.src.structural.decorator
{
    public class BasicCar : ICar
    {
        public string GetDescription()
        {
            return "Basic Car";
        }

        public double GetCost()
        {
            return 20000;
        }
    }
}
