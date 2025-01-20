// File1.cs
namespace CodingDesignPattern.src.creational.builder
{
    public class BuilderProgram
    {
        public void Run()
        {
            var director = new Director();

            // Build a Gaming Computer
            var gamingBuilder = new GamingComputerBuilder();
            director.SetBuilder(gamingBuilder);
            Computer gamingComputer = director.BuildComputer();
            Console.WriteLine(gamingComputer);

            Console.WriteLine();

            // Build an Office Computer
            var officeBuilder = new OfficeComputerBuilder();
            director.SetBuilder(officeBuilder);
            Computer officeComputer = director.BuildComputer();
            Console.WriteLine(officeComputer);
        }
    }
}
