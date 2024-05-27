namespace Memento.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            TextEditorHistory history = new TextEditorHistory();

            textEditor.SetText("First version of text.");
            history.Save(textEditor.SaveTextToMemento());

            textEditor.SetText("Second version of text.");
            history.Save(textEditor.SaveTextToMemento());

            textEditor.SetText("Third version of text.");

            Console.WriteLine("Current Text: " + textEditor.GetText());

            textEditor.RestoreTextFromMemento(history.Undo());
            Console.WriteLine("After undo: " + textEditor.GetText());

            textEditor.RestoreTextFromMemento(history.Undo());
            Console.WriteLine("After second undo: " + textEditor.GetText());

            Console.ReadKey();
        }
    }
}
