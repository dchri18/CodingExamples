namespace Composite.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leaf nodes
            IEmployee emp1 = new Employee("John", "Developer");
            IEmployee emp2 = new Employee("Jane", "Designer");
            IEmployee emp3 = new Employee("Mark", "Developer");

            // Composite node
            Manager manager1 = new Manager("Alice", "Development Manager");
            manager1.AddSubordinate(emp1);
            manager1.AddSubordinate(emp2);

            // Another composite node
            Manager manager2 = new Manager("Bob", "General Manager");
            manager2.AddSubordinate(manager1);
            manager2.AddSubordinate(emp3);

            // Display the organization structure
            manager2.DisplayDetails();
        }
    }
}
