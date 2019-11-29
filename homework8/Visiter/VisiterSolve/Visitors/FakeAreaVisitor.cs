
using System;
using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public class FakeAreaVisitor : IAreaVisitor
    {
        public int GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public int GetTriangleArea(Triangle triangle)
        {
            return (triangle.Height * triangle.Base) / 2;
        }

        public int GetCircleArea(Circle circle)
        {
            return (int) Math.PI * circle.Radius * circle.Radius;
        }
    }
}