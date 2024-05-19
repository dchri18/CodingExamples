namespace Prototype.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create prototypes
            Employee engineerPrototype = new Employee(1, "John Doe", "Engineering", 5000m);
            Employee marketingPrototype = new Employee(2, "Jane Smith", "Marketing", 4500m);

            // Register prototypes
            EmployeeManager.AddPrototype(engineerPrototype);
            EmployeeManager.AddPrototype(marketingPrototype);

            // Create employees from prototypes
            Employee engineer1 = EmployeeManager.GetPrototype("Engineering");
            engineer1.Name = "Bob Johnson";

            Employee engineer2 = EmployeeManager.GetPrototype("Engineering");
            engineer2.Name = "Alice Williams";

            Employee marketer1 = EmployeeManager.GetPrototype("Marketing");
            marketer1.Name = "David Lee";

            // Display employee information
            Console.WriteLine(engineer1);
            Console.WriteLine(engineer2);
            Console.WriteLine(marketer1);
        }
    }
}
