namespace AbstractFactory.Example.Interfaces
{
    public interface ITransportFactory
    {
        IVehicle CreateVehicle();
        ITransport CreateTransport();
    }
}
