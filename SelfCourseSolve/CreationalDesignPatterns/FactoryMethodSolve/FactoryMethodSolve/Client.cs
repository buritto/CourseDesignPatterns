using System;
using FactoryMethodSolve.Logistics;

namespace FactoryMethodSolve
{
    public class Client
    {
        private Logistic _logistic;

        public Client(Logistic logistic)
        {
            _logistic = logistic;
        }

        void DoSomethingWithLogistics()
        {
            //doSomething
            _logistic.PlanDelivery();
            //doSomething
        }
    }
}