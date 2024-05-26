using Proxy.Example.Images;
using Proxy.Example.Interfaces;

namespace Proxy.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("photo1.jpg");
            IImage image2 = new ProxyImage("photo2.jpg");

            // Image is loaded and displayed when Display is called
            image1.Display();
            Console.WriteLine();
            image2.Display();
            Console.WriteLine();

            // Image is already loaded, so only display is called
            image1.Display();
        }
    }
}
