namespace CodingDesignPattern.src.structural.facade
{
    class FacadeProgram
    {
        public void Run()
        {
            CarFacade car = new CarFacade();

            // Start the car using facade
            car.StartCar();

            // Stop the car using facade
            car.StopCar();
        }
    }

}

