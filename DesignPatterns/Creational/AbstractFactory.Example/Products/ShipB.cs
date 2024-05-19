using AbstractFactory.Example.Interfaces;

namespace AbstractFactory.Example.Products
{
    public class ShipB : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transporting via ship from Factory B.");
        }
    }
}
