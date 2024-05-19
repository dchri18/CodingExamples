using AbstractFactory.Example.Interfaces;
using AbstractFactory.Example.Products;

namespace AbstractFactory.Example
{
    public class TransportFactoryA : ITransportFactory
    {
        public IVehicle CreateVehicle()
        {
            return new CarA();
        }

        public ITransport CreateTransport()
        {
            return new TrainA();
        }
    }
}
