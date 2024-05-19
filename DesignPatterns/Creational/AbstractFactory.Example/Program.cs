using AbstractFactory.Example.Interfaces;

namespace AbstractFactory.Example
{
    /// <summary>
    /// Abstract product interfaces: IVehicle and ITransport are the abstract product interfaces that define the 
    ///     contracts for different types of products.
    /// Concrete product classes: CarA, TrainA, CarB, and ShipB are the concrete product classes that implement the 
    ///     abstract product interfaces.
    /// Abstract factory interface: ITransportFactory is the abstract factory interface that declares the factory 
    ///     methods for creating different types of products.
    /// Concrete factory classes: TransportFactoryA and TransportFactoryB are the concrete factory classes that implement 
    ///     the ITransportFactory interface and create instances of the corresponding concrete product classes.
    /// Client code: The client code (Main method) interacts with the concrete factory classes to create instances 
    ///     of the desired products without being coupled to the concrete product classes.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ITransportFactory factoryA = new TransportFactoryA();
            IVehicle carA = factoryA.CreateVehicle();
            ITransport trainA = factoryA.CreateTransport();
            carA.Drive();
            trainA.Transport();

            ITransportFactory factoryB = new TransportFactoryB();
            IVehicle carB = factoryB.CreateVehicle();
            ITransport shipB = factoryB.CreateTransport();
            carB.Drive();
            shipB.Transport();
        }
    }
}
