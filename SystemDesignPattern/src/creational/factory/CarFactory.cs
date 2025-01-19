namespace SystemDesignPattern.src.creational.factory
{
    public static class CarFactory
    {
        public static ICar CreateCar(string carType)
        {
            switch (carType.ToLower())
            {
                case "suv":
                    return new SUV();
                case "sedan":
                    return new Sedan();
                case "sportscar":
                    return new SportsCar();
                default:
                    throw new ArgumentException("Invalid car type.");
            }
        }
    }
}