namespace Flyweight.Example
{
    public class Character : ICharacter
    {
        private readonly char _symbol;

        public Character(char symbol)
        {
            _symbol = symbol;
        }

        public void Display(string font, int size, string color)
        {
            Console.WriteLine($"Character: {_symbol}, Font: {font}, Size: {size}, Color: {color}");
        }
    }
}
