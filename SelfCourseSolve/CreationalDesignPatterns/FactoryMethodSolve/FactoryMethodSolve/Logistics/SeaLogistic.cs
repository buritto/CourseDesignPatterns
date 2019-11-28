using FactoryMethodSolve.Transports;

namespace FactoryMethodSolve.Logistics
{
    public class SeaLogistic : Logistic
    {
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}