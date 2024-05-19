using Factory.Example.Interfaces;

namespace Factory.Example.Products
{
    internal class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck.");
        }
    }
}
