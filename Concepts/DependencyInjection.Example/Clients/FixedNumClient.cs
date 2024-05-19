using DependencyInjection.Example.Interfaces;

namespace DependencyInjection.Example.Clients
{
    internal class FixedNumClient : INumClient
    {
        public int AcquireNumber()
        {
            return 1000;
        }
    }
}
