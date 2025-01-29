namespace CodingDesignPattern.src.behavioural.state
{
    public class Car
    {
        private IGearState _currentState;

        public Car()
        {
            _currentState = new NeutralState(); // Default state
        }

        public void SetState(IGearState newState)
        {
            _currentState = newState;
        }

        public void ShiftUp()
        {
            _currentState.ShiftUp(this);
        }

        public void ShiftDown()
        {
            _currentState.ShiftDown(this);
        }

        public void Accelerate()
        {
            _currentState.Accelerate();
        }
    }
}