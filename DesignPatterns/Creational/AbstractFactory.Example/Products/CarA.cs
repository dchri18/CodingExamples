using AbstractFactory.Example.Interfaces;

namespace AbstractFactory.Example.Products
{
    public class CarA : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car from Factory A.");
        }
    }
}
