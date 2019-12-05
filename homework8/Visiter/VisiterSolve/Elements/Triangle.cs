using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public class Triangle : IElement
    {
        public int Base;
        public int Height;
        

        public void Accept(IVisitor visitor)
        {
           visitor.VisitTriangle(this);
        }
    }
}