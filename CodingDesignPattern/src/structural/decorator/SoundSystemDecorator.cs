namespace CodingDesignPattern.src.structural.decorator
{
    public class SoundSystemDecorator : CarDecorator
    {
        public SoundSystemDecorator(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Premium Sound System";
        }

        public override double GetCost()
        {
            return base.GetCost() + 2500;
        }
    }
}
