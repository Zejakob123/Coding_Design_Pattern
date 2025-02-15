namespace CodingDesignPattern.src.structural.proxy
{

    class ProxyProgram
    {
        public void Run()
        {
            ICarImage car1 = new ProxyCarImage("sedan.jpg");
            ICarImage car2 = new ProxyCarImage("suv.jpg");

            // Images are not loaded yet
            Console.WriteLine("Images not loaded yet.");

            // Display images when actually needed
            car1.Display(); // Loads and displays sedan.jpg
            car2.Display(); // Loads and displays suv.jpg

            // Image is already loaded, will only display now
            car1.Display();
        }
    }
}
