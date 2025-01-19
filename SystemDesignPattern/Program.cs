// See https://aka.ms/new-console-template for more information
using SystemDesignPattern.src.creational.factory;

namespace SystemDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var fp = new FactoryProgram();
            fp.Run();
        }
    }
}