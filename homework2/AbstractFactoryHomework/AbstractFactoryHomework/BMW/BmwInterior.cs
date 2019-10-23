using AbstractFactoryHomework.AbstractFactory;

namespace AbstractFactoryHomework.BMW
{
    internal class BmwInterior : IVehicleInterior
    {
        public TypeInterior Interior => TypeInterior.Leather;
    }
}