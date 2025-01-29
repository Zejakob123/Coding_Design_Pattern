namespace CodingDesignPattern.src.behavioural.state
{
    public class NeutralState : IGearState
    {
        public void ShiftUp(Car car)
        {
            Console.WriteLine("Shifting from Neutral to Drive.");
            car.SetState(new DriveState());
        }

        public void ShiftDown(Car car)
        {
            Console.WriteLine("Already in Neutral. Cannot shift down.");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is in Neutral. Cannot accelerate.");
        }
    }
}