namespace CodingDesignPattern.src.behavioural.visitor
{
    public interface ICarVisitor
    {
        void Visit(Sedan sedan);
        void Visit(SUV suv);
        void Visit(SportsCar sportsCar);
    }
}