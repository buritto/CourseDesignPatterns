using VisiterSolve.Visitors;

namespace VisiterSolve.Elements
{
    public interface IElement
    {
        void AcceptDrawer(IDrawVisitor visitor);

        int AcceptArea(IAreaVisitor visitor);

        object AcceptMagic(ISomeMagicVisitor visitor);
    }
}