using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public class Triangle : IElement
    {
        public int Base;
        public int Height;

        public void AcceptDrawer(IDrawVisitor visitor)
        {
            visitor.DrawTriangle(this);
        }

        public int AcceptArea(IAreaVisitor visitor)
        {
            return visitor.GetTriangleArea(this);
        }

        public object AcceptMagic(ISomeMagicVisitor visitor)
        {
            return visitor.MakeTriangleMagic(this);
        }
    }
}