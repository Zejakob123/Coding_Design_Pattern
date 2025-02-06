namespace CodingDesignPattern.src.structural.bridge
{
    public class SUV : Car
    {
        public SUV(IEngine engine) : base(engine) { }

        public override void Drive()
        {
            Console.Write("SUV is driving with ");
            _engine.Start();
        }
    }
}