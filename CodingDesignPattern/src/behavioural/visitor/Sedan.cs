namespace CodingDesignPattern.src.behavioural.visitor
{
     public class Sedan : ICar
    {
        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetSedanInfo()
        {
            return "Sedan: A comfortable family car.";
        }
    }
}