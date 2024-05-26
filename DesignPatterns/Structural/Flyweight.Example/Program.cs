namespace Flyweight.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();

            string document = "Hello World!";
            string font = "Arial";
            int size = 12;
            string color = "Black";

            foreach (char symbol in document)
            {
                ICharacter character = factory.GetCharacter(symbol);
                character.Display(font, size, color);
            }
        }
    }
}
