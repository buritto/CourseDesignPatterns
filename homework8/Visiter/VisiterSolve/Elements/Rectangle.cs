using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public class Rectangle : IElement
    {
        public int Height;
        public int Width;

        public void AcceptDrawer(IDrawVisitor visitor)
        {
            visitor.DrawRectangle(this);
        }

        public int AcceptArea(IAreaVisitor visitor)
        {
            return visitor.GetRectangleArea(this);
        }

        public object AcceptMagic(ISomeMagicVisitor visitor)
        {
            return visitor.MakeRectangleMagic(this);
        }
    }
}