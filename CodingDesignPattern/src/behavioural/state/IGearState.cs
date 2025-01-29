namespace CodingDesignPattern.src.behavioural.state
{
    public interface IGearState
    {
        void ShiftUp(Car car);
        void ShiftDown(Car car);
        void Accelerate();
    }
}