using System;
using System.Collections.Generic;
using VisiterSolve.Elements;
using VisiterSolve.Visitors;

namespace VisiterSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<IElement>
            {
                new Circle
                {
                    Radius = 2
                },
                new Rectangle
                {
                    Height = 3,
                    Width = 2
                },
                new Triangle
                {
                    Base = 3,
                    Height = 2
                }
            };

            var areaVisitor = new FakeAreaVisitor();

            figures.ForEach(x => Console.WriteLine($"{x.GetType().Name} - {x.AcceptArea(areaVisitor)}"));
        }
    }
}