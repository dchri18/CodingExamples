namespace Memento.Example
{
    public class TextMemento
    {
        public string Text { get; private set; }

        public TextMemento(string text)
        {
            Text = text;
        }
    }
}