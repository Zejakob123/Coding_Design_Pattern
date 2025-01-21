namespace CodingDesignPattern.src.creational.prototype
{
    public class Sedan : ICarPrototype
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Seats { get; set; }

        public Sedan(string model, string engine, int seats)
        {
            Model = model;
            Engine = engine;
            Seats = seats;
        }

        // Clone method implementation
        public ICarPrototype Clone()
        {
            return new Sedan(Model, Engine, Seats);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Sedan - Model: {Model}, Engine: {Engine}, Seats: {Seats}");
        }
    }
}