using AbstractFactoryHomework.AbstractFactory;

namespace AbstractFactoryHomework.BMW
{
    public class BmwCarFactory : ICarFactory
    {
        public ICarBody CreateBody()
        {
            return new BmwBody();
        }

        public IEngine CreateEngine()
        {
            return new BmwEngine();
        }

        public IVehicleInterior CreateInterior()
        {
            return new BmwInterior();
        }
    }
}