namespace CodingDesignPattern.src.structural.decorator
{
    public class GPSDecorator : CarDecorator
    {
        public GPSDecorator(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", GPS";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1500;
        }
    }
}
