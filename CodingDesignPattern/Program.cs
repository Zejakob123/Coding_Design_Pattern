﻿// See https://aka.ms/new-console-template for more information
using CodingDesignPattern.src.creational.factory;
using CodingDesignPattern.src.creational.builder;
using CodingDesignPattern.src.creational.prototype;

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
            new PrototypePatternDemo().Run();
        }
    }
}