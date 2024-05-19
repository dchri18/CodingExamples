using Microsoft.Extensions.DependencyInjection;
using DependencyInjection.Example.Clients;
using DependencyInjection.Example.Services;
using DependencyInjection.Example.Interfaces;

namespace DependencyInjection.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create service collection
            var services = new ServiceCollection();
            services.AddTransient<INumClient, RandomNumClient>();
            services.AddTransient<NumService>();

            // Build service provider
            var serviceProvider = services.BuildServiceProvider();

            int num = serviceProvider.GetService<NumService>().AcquireNumber();
            Console.WriteLine(num);
        }
    }
}
