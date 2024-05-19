using DependencyInjection.Example.Interfaces;

namespace DependencyInjection.Example.Clients
{
    internal class RandomNumClient : INumClient
    {
        public int AcquireNumber()
        {
            return new Random((int)DateTime.Now.Ticks).Next(0, 100);
        }
    }
}
