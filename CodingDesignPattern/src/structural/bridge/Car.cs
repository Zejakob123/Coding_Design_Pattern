namespace CodingDesignPattern.src.structural.bridge
{
    public abstract class Car
    {
        protected IEngine _engine; // Bridge to the engine implementation

        protected Car(IEngine engine)
        {
            _engine = engine;
        }

        public abstract void Drive();
    }
}