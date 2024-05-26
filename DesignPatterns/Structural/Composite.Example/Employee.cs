namespace Composite.Example
{
    public class Employee : IEmployee
    {
        private string _name;
        private string _position;

        public Employee(string name, string position)
        {
            _name = name;
            _position = position;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{_name} works as {_position}");
        }
    }
}
