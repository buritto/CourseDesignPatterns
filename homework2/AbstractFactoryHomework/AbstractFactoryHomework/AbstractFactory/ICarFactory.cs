namespace AbstractFactoryHomework.AbstractFactory
{
    public interface ICarFactory
    {
        ICarBody CreateBody();
        IEngine CreateEngine();
        IVehicleInterior CreateInterior();
    }
}