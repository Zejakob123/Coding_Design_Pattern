namespace CodingDesignPattern.src.structural.facade
{
    public class CarFacade
    {
        private Engine _engine;
        private FuelInjector _fuelInjector;
        private AirFlowController _airFlowController;

        public CarFacade()
        {
            _engine = new Engine();
            _fuelInjector = new FuelInjector();
            _airFlowController = new AirFlowController();
        }

        public void StartCar()
        {
            Console.WriteLine("Starting the car...");
            _airFlowController.TakeAir();
            _fuelInjector.Inject();
            _engine.Start();
            Console.WriteLine("Car started successfully.\n");
        }

        public void StopCar()
        {
            Console.WriteLine("Stopping the car...");
            _engine.Stop();
            _fuelInjector.ShutOff();
            _airFlowController.StopAir();
            Console.WriteLine("Car stopped successfully.\n");
        }
    }
}
