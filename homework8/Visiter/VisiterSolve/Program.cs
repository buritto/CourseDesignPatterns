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
            var areaVisitor = new AreaVisitor();
            var drawVisitor = new DrawVisitor();
            var magicVisitor = new MagicVisitor();

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


            figures.ForEach(x => x.Accept(areaVisitor));
            figures.ForEach(x => x.Accept(drawVisitor));
            figures.ForEach(x => x.Accept(magicVisitor));
        }
    }
}