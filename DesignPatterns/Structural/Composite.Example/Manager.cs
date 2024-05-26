namespace Composite.Example
{
    public class Manager : IEmployee
    {
        private string _name;
        private string _position;
        private List<IEmployee> _subordinates = new List<IEmployee>();

        public Manager(string name, string position)
        {
            _name = name;
            _position = position;
        }

        public void AddSubordinate(IEmployee employee)
        {
            _subordinates.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            _subordinates.Remove(employee);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{_name} works as {_position}");
            foreach (var subordinate in _subordinates)
            {
                subordinate.DisplayDetails();
            }
        }
    }
}
