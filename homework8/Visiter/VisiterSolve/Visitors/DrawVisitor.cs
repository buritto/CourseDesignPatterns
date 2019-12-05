using System;
using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public class DrawVisitor : IVisitor
    {
        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine("Draw rectangle");
        }

        public void VisitTriangle(Triangle triangle)
        {
            Console.WriteLine("Draw triangle");
        }

        public void VisitCircle(Circle circle)
        {
            Console.WriteLine("Draw circle");
        }
    }
}