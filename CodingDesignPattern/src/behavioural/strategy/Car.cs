namespace CodingDesignPattern.src.behavioural.strategy
{
    public class Car
    {
        private IDriveStrategy _driveStrategy;

        // Constructor to set the initial strategy
        public Car(IDriveStrategy driveStrategy)
        {
            _driveStrategy = driveStrategy;
        }

        // Method to change the strategy dynamically
        public void SetDriveStrategy(IDriveStrategy driveStrategy)
        {
            _driveStrategy = driveStrategy;
        }

        // Method to execute the current strategy
        public void Drive()
        {
            _driveStrategy.Drive();
        }
    }
}