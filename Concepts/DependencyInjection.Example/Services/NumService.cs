using DependencyInjection.Example.Interfaces;

namespace DependencyInjection.Example.Services
{
    public class NumService
    {
        private INumClient _client;

        public NumService(INumClient client)
        {
            _client = client;
        }

        public int AcquireNumber()
        {
            return _client.AcquireNumber();
        }
    }
}
