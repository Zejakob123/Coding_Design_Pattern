namespace CodingDesignPattern.src.behavioural.mediator
{
    public interface ICarMediator
    {
        void SendMessage(string message, CarDealer sender);
    }
}