namespace CodingDesignPattern.src.behavioural.iterator
{
    class IteratorProgram
    {
        public void Run()
        {
            CarCollection carCollection = new CarCollection();
            carCollection.AddCar(new Car("Sedan"));
            carCollection.AddCar(new Car("SUV"));
            carCollection.AddCar(new Car("Sports Car"));

            ICarIterator iterator = carCollection.CreateIterator();

            Console.WriteLine("Iterating through car collection:");
            while (iterator.HasNext())
            {
                Car car = iterator.Next();
                Console.WriteLine($"Car: {car.Name}");
            }
        }
    }
}