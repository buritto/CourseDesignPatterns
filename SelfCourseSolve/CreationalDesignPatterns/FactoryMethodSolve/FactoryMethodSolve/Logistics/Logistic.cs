using FactoryMethodSolve.Transports;

namespace FactoryMethodSolve.Logistics
{
    public abstract class Logistic()
    {
        public void PlanDelivery()
        {
            //doSomething;
            var transport = CreateTransport();
            //doSomethingWithTransport
        }

        protected abstract ITransport CreateTransport();
    }
}