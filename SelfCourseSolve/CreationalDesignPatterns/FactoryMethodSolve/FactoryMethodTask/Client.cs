using System;

namespace FactoryMethodCommon
{
    public class Transport
    {
    }

    public class Logistic
    {
        public object GetDeliveryPlan()
        {
            //doSomething
            var tr = new Transport();
            //use transport 
            return new object();
        }
    }

    public class Client
    {
        private Logistic _logistic;

        void DoSomethingWithLogistics()
        {
            var delivery = _logistic.GetDeliveryPlan();
            //doSomethingWithDelivery;
        }
    }
}