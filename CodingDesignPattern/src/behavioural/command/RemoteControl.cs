namespace CodingDesignPattern.src.behavioural.command
{
    public class RemoteControl
    {
        private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                var lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }
}