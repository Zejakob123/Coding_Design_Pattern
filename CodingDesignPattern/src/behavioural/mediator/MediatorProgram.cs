namespace CodingDesignPattern.src.behavioural.mediator
{
    class MediatorProgram
    {
        public void Run()
        {
            // Create Mediator
            CarShowroomMediator mediator = new CarShowroomMediator();

            // Create Dealers
            SedanDealer sedanDealer = new SedanDealer(mediator, "Sedan King");
            SUVDealer suvDealer = new SUVDealer(mediator, "SUV Master");

            // Register Dealers to the Mediator
            mediator.RegisterDealer(sedanDealer);
            mediator.RegisterDealer(suvDealer);

            // Dealers Communicating through Mediator
            sedanDealer.SendMessage("We have a new model of sedan available!");
            Console.WriteLine();

            suvDealer.SendMessage("We are offering discounts on SUVs this week!");
        }
    }
}