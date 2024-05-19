using AbstractFactory.Example.Interfaces;
using AbstractFactory.Example.Products;

namespace AbstractFactory.Example
{
    public class TransportFactoryB : ITransportFactory
    {
        public IVehicle CreateVehicle()
        {
            return new CarB();
        }

        public ITransport CreateTransport()
        {
            return new ShipB();
        }
    }
}
