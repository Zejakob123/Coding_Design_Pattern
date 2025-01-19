namespace SystemDesignPattern.src.creational.factory
{
    public interface ICar
    {
        void Drive();
    }

    public class Sedan : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Sedan.");
        }
    }

    public class SUV : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving an SUV.");
        }
    }

    public class SportsCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Sports Car.");
        }
    }
}