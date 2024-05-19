using AbstractFactory.Example.Interfaces;

namespace AbstractFactory.Example.Products
{
    public class TrainA : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transporting via train from Factory A.");
        }
    }
}
