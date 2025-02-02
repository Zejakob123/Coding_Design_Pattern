namespace CodingDesignPattern.src.behavioural.observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string carModel);
    }
}