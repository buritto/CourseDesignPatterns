using System;
using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public class AreaVisitor : IVisitor
    {
        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Height * rectangle.Width);
        }

        public void VisitTriangle(Triangle triangle)
        {
            Console.WriteLine((triangle.Base * triangle.Height) / 2);
        }

        public void VisitCircle(Circle circle)
        {
            Console.WriteLine(Math.Pow(circle.Radius, 2) * Math.PI);
        }
    }
}