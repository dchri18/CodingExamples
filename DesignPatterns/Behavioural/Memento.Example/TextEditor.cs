namespace Memento.Example
{
    public class TextEditor
    {
        private string _text;

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }

        public TextMemento SaveTextToMemento()
        {
            return new TextMemento(_text);
        }

        public void RestoreTextFromMemento(TextMemento memento)
        {
            _text = memento.Text;
        }
    }
}
