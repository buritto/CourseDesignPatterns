using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public class Rectangle : IElement
    {
        public int Height;
        public int Width;


        public void Accept(IVisitor visitor)
        {
            visitor.VisitRectangle(this);
        }
    }
}