namespace CodingDesignPattern.src.behavioural.mediator
{
    public class CarShowroomMediator : ICarMediator
    {
        private List<CarDealer> _dealers = new List<CarDealer>();

        public void RegisterDealer(CarDealer dealer)
        {
            _dealers.Add(dealer);
        }

        public void SendMessage(string message, CarDealer sender)
        {
            foreach (var dealer in _dealers)
            {
                // Dealers should not receive their own messages
                if (dealer != sender)
                {
                    dealer.ReceiveMessage(message);
                }
            }
        }
    }
}