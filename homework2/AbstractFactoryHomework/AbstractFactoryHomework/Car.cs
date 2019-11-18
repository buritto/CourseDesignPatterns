using AbstractFactoryHomework.AbstractFactory;

namespace AbstractFactoryHomework
{
    public class Car
    {
        private Car(ICarBody carBody, IEngine engine, IVehicleInterior interior)
        {
            CarBody = carBody;
            Engine = engine;
            Interior = interior;
        }

        public ICarBody CarBody { get; }

        public IEngine Engine { get; }

        public IVehicleInterior Interior { get; }

        public static Car CreateCar(ICarFactory factory)
        {
            var body = factory.CreateBody();
            var engine = factory.CreateEngine();
            var interior = factory.CreateInterior();

            return new Car(body, engine, interior);
        }
    }
}