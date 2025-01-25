namespace CodingDesignPattern.src.behavioural.visitor
{
    public interface ICar
    {
        void Accept(ICarVisitor visitor);
    }
}