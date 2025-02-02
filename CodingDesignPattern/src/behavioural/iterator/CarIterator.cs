namespace CodingDesignPattern.src.behavioural.iterator
{
    public class CarIterator : ICarIterator
    {
        private readonly List<Car> _cars;
        private int _position = 0;

        public CarIterator(List<Car> cars)
        {
            _cars = cars;
        }

        public bool HasNext()
        {
            return _position < _cars.Count;
        }

        public Car Next()
        {
            return HasNext() ? _cars[_position++] : null;
        }
    }
}