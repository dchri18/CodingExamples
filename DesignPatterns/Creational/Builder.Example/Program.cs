using Builder.Example.Products;

namespace Builder.Example
{
    /// <summary>
    /// Product class: The Computer class represents the complex object that we want to build. 
    ///     It contains properties for different computer components.
    /// Builder interface: The IComputerBuilder interface defines the methods for setting different components 
    ///     of the computer and a Build method to construct the final Computer object.
    /// Concrete builder class: The ComputerBuilder class is the concrete implementation of the IComputerBuilder interface. 
    ///     It maintains an instance of the Computer object and provides methods to set different components. The Build method returns the constructed Computer object.
    /// Director class (optional): The ComputerDirector class is an optional class that encapsulates different 
    ///     construction sequences for building specific types of computers (e.g., gaming, office). This class uses the ComputerBuilder to construct the desired computer configurations.
    /// Fluent interface: The builder implementation uses a fluent interface pattern, where each setter method returns 
    ///     the builder instance, allowing method chaining for a more readable and expressive construction code.
    /// Client code: The client code (Main method) demonstrates how to use the ComputerBuilder directly or through the 
    ///     ComputerDirector to build different computer configurations.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerDirector director = new ComputerDirector(new ComputerBuilder());
            Computer officeComputer = director.BuildOfficeComputer();

            Console.WriteLine(officeComputer);
        }
    }
}
