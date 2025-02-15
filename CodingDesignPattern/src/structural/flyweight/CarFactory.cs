namespace CodingDesignPattern.src.structural.flyweight
{
    public class CarFactory
    {
        private Dictionary<string, ICar> _cars = new Dictionary<string, ICar>();

        public ICar GetCar(string carType)
        {
            if (!_cars.ContainsKey(carType))
            {
                switch (carType)
                {
                    case "sedan":
                        _cars[carType] = new Sedan();
                        break;
                    case "suv":
                        _cars[carType] = new SUV();
                        break;
                    case "sports":
                        _cars[carType] = new SportsCar();
                        break;
                }
            }
            return _cars[carType];
        }

        public int CarsCount()
        {
            return _cars.Count;
        }
    }
}
