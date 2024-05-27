namespace Memento.Example
{
    public class TextEditorHistory
    {
        private readonly Stack<TextMemento> _history = new Stack<TextMemento>();

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
