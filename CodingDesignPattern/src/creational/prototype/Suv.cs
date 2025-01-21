namespace CodingDesignPattern.src.creational.prototype
{
    public class SUV : ICarPrototype
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public int GroundClearance { get; set; }

        public SUV(string model, string engine, int groundClearance)
        {
            Model = model;
            Engine = engine;
            GroundClearance = groundClearance;
        }

        // Clone method implementation
        public ICarPrototype Clone()
        {
            return new SUV(Model, Engine, GroundClearance);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"SUV - Model: {Model}, Engine: {Engine}, Ground Clearance: {GroundClearance} mm");
        }
    }
}