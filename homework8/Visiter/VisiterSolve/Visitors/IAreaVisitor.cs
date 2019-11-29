using System.Text.RegularExpressions;
using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public interface IAreaVisitor
    {
        int GetRectangleArea(Rectangle rectangle);
        int GetTriangleArea(Triangle triangle);
        int GetCircleArea(Circle circle);
    }
}