namespace CodingDesignPattern.src.behavioural.iterator
{
    public class CarCollection : ICarCollection
    {
        private List<Car> _cars = new List<Car>();

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public ICarIterator CreateIterator()
        {
            return new CarIterator(_cars);
        }
    }
}