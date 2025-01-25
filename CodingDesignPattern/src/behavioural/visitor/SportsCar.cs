namespace CodingDesignPattern.src.behavioural.visitor
{
    public class SportsCar : ICar
    {
        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetSportsCarInfo()
        {
            return "SportsCar: High performance and speed.";
        }
    }
}