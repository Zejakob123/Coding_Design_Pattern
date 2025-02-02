namespace CodingDesignPattern.src.behavioural.mediator
{
    public abstract class CarDealer
    {
        protected ICarMediator _mediator;
        public string Name { get; }

        public CarDealer(ICarMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }
}