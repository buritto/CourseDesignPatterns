using VisiterSolve.Elements;

namespace VisiterSolve.Visitors
{
    public interface ISomeMagicVisitor
    {
        object MakeRectangleMagic(Rectangle rectangle);
        object MakeTriangleMagic(Triangle rectangle);
        object MakeCircleMagic(Circle circle);
    }
}