using FactoryMethodSolve.Transports;

namespace FactoryMethodSolve.Logistics
{
    public class RoadLogistic : Logistic
    {
        protected override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}