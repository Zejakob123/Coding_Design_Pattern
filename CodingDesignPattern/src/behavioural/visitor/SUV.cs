namespace CodingDesignPattern.src.behavioural.visitor
{
    public class SUV : ICar
    {
        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetSUVInfo()
        {
            return "SUV: A large family car.";
        }
    }
}