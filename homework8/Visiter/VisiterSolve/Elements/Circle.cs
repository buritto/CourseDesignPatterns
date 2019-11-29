using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public class Circle : IElement
    {
        public int Radius;

        public void AcceptDrawer(IDrawVisitor visitor)
        {
            visitor.DrawCircle(this);
        }

        public int AcceptArea(IAreaVisitor visitor)
        {
            return visitor.GetCircleArea(this);
        }

        public object AcceptMagic(ISomeMagicVisitor visitor)
        {
            return visitor.MakeCircleMagic(this);
        }
    }
}