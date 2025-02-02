namespace CodingDesignPattern.src.behavioural.mediator
{
    public class SedanDealer : CarDealer
    {
        public SedanDealer(ICarMediator mediator, string name) : base(mediator, name) { }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"{Name} (Sedan Dealer) sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} (Sedan Dealer) received: {message}");
        }
    }
}