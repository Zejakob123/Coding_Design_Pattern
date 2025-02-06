namespace CodingDesignPattern.src.structural.bridge
{
    public class Sedan : Car
    {
        public Sedan(IEngine engine) : base(engine) { }

        public override void Drive()
        {
            Console.Write("Sedan is driving with ");
            _engine.Start();
        }
    }
}