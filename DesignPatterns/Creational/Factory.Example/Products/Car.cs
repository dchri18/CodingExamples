using Factory.Example.Interfaces;

namespace Factory.Example.Products
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }
}
