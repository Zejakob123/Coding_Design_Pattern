namespace CodingDesignPattern.src.behavioural.memento
{
    public class EditorHistory
    {
        private Stack<TextMemento> _history = new Stack<TextMemento>();

        public void Save(TextMemento memento)
        {
            _history.Push(memento);
        }

        public TextMemento Undo()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }
}