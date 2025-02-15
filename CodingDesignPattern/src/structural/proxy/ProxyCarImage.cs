using System;

namespace CodingDesignPattern.src.structural.proxy
{
    public class ProxyCarImage : ICarImage
    {
        private RealCarImage _realCarImage;
        private string _fileName;

        public ProxyCarImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realCarImage == null)
            {
                _realCarImage = new RealCarImage(_fileName);
            }
            Console.WriteLine("Proxy: Displaying image on-demand.");
            _realCarImage.Display();
        }
    }
}
