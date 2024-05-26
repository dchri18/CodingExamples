using Decorator.Example.Decorators;
using Decorator.Example.Interfaces;

namespace Decorator.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new PlainCoffee();
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost():C}");

            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost():C}");

            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost():C}");

            coffee = new WhippedCreamDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost():C}");
        }
    }
}
