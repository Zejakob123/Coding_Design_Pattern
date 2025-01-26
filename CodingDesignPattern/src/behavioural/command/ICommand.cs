namespace CodingDesignPattern.src.behavioural.command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}