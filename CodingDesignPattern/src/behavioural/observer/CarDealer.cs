namespace CodingDesignPattern.src.behavioural.observer
{
    public class CarDealer : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string carModel)
        {
            Console.WriteLine($"CarDealer: New car model {carModel} is available!");
            foreach (var observer in _observers)
            {
                observer.Update(carModel);
            }
        }
    }
}