using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public class Circle : IElement
    {
        public int Radius;

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }
}