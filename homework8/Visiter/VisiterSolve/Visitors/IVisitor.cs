using System.Text.RegularExpressions;
using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public interface IVisitor
    {
        void VisitRectangle(Rectangle rectangle);
        void VisitTriangle(Triangle triangle);

        void VisitCircle(Circle circle);
    }
}