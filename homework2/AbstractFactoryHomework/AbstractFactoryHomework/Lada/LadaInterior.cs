using AbstractFactoryHomework.AbstractFactory;

namespace AbstractFactoryHomework.Lada
{
    internal class LadaInterior : IVehicleInterior
    {
        public TypeInterior Interior => TypeInterior.Cloth;
    }
}