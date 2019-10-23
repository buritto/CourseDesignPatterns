using AbstractFactoryHomework.AbstractFactory;
using AbstractFactoryHomework.BMW;

namespace AbstractFactoryHomework.Lada
{
    public class LadaCarFactory : ICarFactory
    {
        public ICarBody CreateBody()
        {
            return new LadaCarBody();
        }

        public IEngine CreateEngine()
        {
            return new LadaEngine();
        }

        public IVehicleInterior CreateInterior()
        {
            return new LadaInterior();
        }
    }
}