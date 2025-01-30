namespace CodingDesignPattern.src.behavioural.memento
{
    class MementoProgram
    {
        public void Run()
        {
            TextEditor editor = new TextEditor();
            EditorHistory history = new EditorHistory();

            editor.Type("Hello, ");
            history.Save(editor.Save());  // Save state

            editor.Type("world!");
            history.Save(editor.Save());  // Save state

            Console.WriteLine("Current Content: " + editor.GetContent());  // Output: Hello, world!

            editor.Restore(history.Undo());  // Undo
            Console.WriteLine("After Undo: " + editor.GetContent());  // Output: Hello, 

            editor.Restore(history.Undo());  // Undo again
            Console.WriteLine("After Second Undo: " + editor.GetContent());  // Output: (empty)
        }
    }
}