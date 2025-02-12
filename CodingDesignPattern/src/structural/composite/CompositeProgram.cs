namespace CodingDesignPattern.src.structural.composite
{
    // Composite - A collection of car parts
    class CompositeProgram
    {
        public void Run()
        {
            // Create individual car parts
            ICarComponent engine = new CarPart("Engine");
            ICarComponent wheel1 = new CarPart("Front Left Wheel");
            ICarComponent wheel2 = new CarPart("Front Right Wheel");
            ICarComponent wheel3 = new CarPart("Rear Left Wheel");
            ICarComponent wheel4 = new CarPart("Rear Right Wheel");
            ICarComponent door = new CarPart("Door");

            // Create a composite Car
            CarComposite car = new CarComposite("Sedan");

            // Add individual parts to the car
            car.AddComponent(engine);
            car.AddComponent(wheel1);
            car.AddComponent(wheel2);
            car.AddComponent(wheel3);
            car.AddComponent(wheel4);
            car.AddComponent(door);

            // Show car details
            car.ShowDetails();
        }
    }
}