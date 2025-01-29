namespace CodingDesignPattern.src.behavioural.state
{
    public class DriveState : IGearState
    {
        public void ShiftUp(Car car)
        {
            Console.WriteLine("Already in Drive. Cannot shift up.");
        }

        public void ShiftDown(Car car)
        {
            Console.WriteLine("Shifting from Drive to Neutral.");
            car.SetState(new NeutralState());
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating in Drive mode.");
        }
    }
}