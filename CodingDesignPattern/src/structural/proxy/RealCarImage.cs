using System;

namespace CodingDesignPattern.src.structural.proxy
{
    public class RealCarImage : ICarImage
    {
        private string _fileName;

        public RealCarImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {_fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_fileName}");
        }
    }
}
