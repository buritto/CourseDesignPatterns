using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public interface IDrawVisitor
    {
        void DrawRectangle(Rectangle rectangle);
        void DrawTriangle(Triangle triangle);
        void DrawCircle(Circle circle);
    }
}