namespace CodingDesignPattern.src.behavioural.memento
{
    public class TextEditor
    {
        private string _content = "";

        public void Type(string words)
        {
            _content += words;
        }

        public string GetContent()
        {
            return _content;
        }

        // Save current state as a Memento
        public TextMemento Save()
        {
            return new TextMemento(_content);
        }

        // Restore the state from a Memento
        public void Restore(TextMemento memento)
        {
            _content = memento.Content;
        }
    }
}