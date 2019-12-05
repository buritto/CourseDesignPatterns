using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}