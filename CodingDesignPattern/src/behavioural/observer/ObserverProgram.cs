namespace CodingDesignPattern.src.behavioural.observer
{
    class ObserverProgram
    {
        public void Run()
        {
            // Create CarDealer (Subject)
            CarDealer dealer = new CarDealer();

            // Create CarBuyers (Observers)
            CarBuyer buyer1 = new CarBuyer("Alice");
            CarBuyer buyer2 = new CarBuyer("Bob");

            // Buyers subscribe to the dealer's notifications
            dealer.RegisterObserver(buyer1);
            dealer.RegisterObserver(buyer2);

            // Dealer announces a new car model
            dealer.NotifyObservers("Sedan X");

            // Bob is no longer interested and unsubscribes
            dealer.RemoveObserver(buyer2);

            // Another car model is announced
            dealer.NotifyObservers("SUV Z");
        }
    }
}