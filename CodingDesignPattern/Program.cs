// See https://aka.ms/new-console-template for more information
using CodingDesignPattern.src.creational.factory;
using CodingDesignPattern.src.creational.builder;
using CodingDesignPattern.src.creational.prototype;

using CodingDesignPattern.src.behavioural.strategy;
using CodingDesignPattern.src.behavioural.visitor;
using CodingDesignPattern.src.behavioural.chainOfResponsibility;
using CodingDesignPattern.src.behavioural.command;
using CodingDesignPattern.src.behavioural.state;
using CodingDesignPattern.src.behavioural.memento;
using CodingDesignPattern.src.behavioural.iterator;
using CodingDesignPattern.src.behavioural.mediator;

namespace CodingDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Pattern
            /* var fp = new FactoryProgram();
            fp.Run(); */

            // Builder Pattern
            /* var bp = new BuilderProgram();
            bp.Run(); */

            // Prototype Pattern
            // new PrototypePatternDemo().Run();

            // Strategy Pattern
            // var sp = new StrategyProgram();
            // sp.Run();

            // Visitor Pattern
            // var vp = new VisitorProgram();
            // vp.Run();

            // Chain of Responsibility Pattern
            // new CORProgram().Run();

            // Command Pattern
            // new CommandProgram().Run();

            // State Pattern
            // new StateProgram().Run();

            // Memento Pattern
            // new MementoProgram().Run();

            // Iterator Pattern
            // new IteratorProgram().Run();s

            // Mediator Pattern
            new MediatorProgram().Run();
        }
    }
}