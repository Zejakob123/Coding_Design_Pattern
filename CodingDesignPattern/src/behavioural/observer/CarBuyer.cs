namespace CodingDesignPattern.src.behavioural.observer
{
    public class CarBuyer : IObserver
    {
        private string _name;

        public CarBuyer(string name)
        {
            _name = name;
        }

        public void Update(string carModel)
        {
            Console.WriteLine($"{_name} received an alert: New car available - {carModel}");
        }
    }
}