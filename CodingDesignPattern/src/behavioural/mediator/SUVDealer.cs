namespace CodingDesignPattern.src.behavioural.mediator
{
    public class SUVDealer : CarDealer
    {
        public SUVDealer(ICarMediator mediator, string name) : base(mediator, name) { }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"{Name} (SUV Dealer) sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} (SUV Dealer) received: {message}");
        }
    }
}