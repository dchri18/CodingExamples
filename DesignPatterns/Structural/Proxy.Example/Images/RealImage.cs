using Proxy.Example.Interfaces;

namespace Proxy.Example.Images
{
    public class RealImage : IImage
    {
        private readonly string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {_filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_filename}");
        }
    }
}
