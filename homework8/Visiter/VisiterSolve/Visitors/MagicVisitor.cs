using System;
using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public class MagicVisitor : IVisitor
    {
        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine("Do some magic for rectangle");
        }

        public void VisitTriangle(Triangle triangle)
        {
            Console.WriteLine("Do some magic for triangle");
        }

        public void VisitCircle(Circle circle)
        {
            Console.WriteLine("Do some magic for circle");
        }
    }
}