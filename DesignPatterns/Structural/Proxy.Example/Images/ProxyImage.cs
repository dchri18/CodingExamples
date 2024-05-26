using Proxy.Example.Interfaces;

namespace Proxy.Example.Images
{
    public class ProxyImage : IImage
    {
        private readonly string _filename;
        private RealImage _realImage;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }
}
