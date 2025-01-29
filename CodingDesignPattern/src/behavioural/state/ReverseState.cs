namespace CodingDesignPattern.src.behavioural.state
{
    public class ReverseState : IGearState
    {
        public void ShiftUp(Car car)
        {
            Console.WriteLine("Shifting from Reverse to Neutral.");
            car.SetState(new NeutralState());
        }

        public void ShiftDown(Car car)
        {
            Console.WriteLine("Already in Reverse. Cannot shift down.");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is reversing.");
        }
    }
}