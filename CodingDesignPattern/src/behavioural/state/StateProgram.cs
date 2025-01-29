namespace CodingDesignPattern.src.behavioural.state
{
    class StateProgram
    {
        public void Run()
        {
            Car car = new Car();

            car.Accelerate(); // Neutral: Cannot accelerate
            car.ShiftUp();    // Shift to Drive
            car.Accelerate(); // Drive: Car is accelerating
            car.ShiftDown();  // Shift to Neutral
            car.ShiftDown();  // Already in Neutral
            car.ShiftUp();    // Shift to Drive
        }
    }
}