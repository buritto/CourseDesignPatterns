using System.ComponentModel.DataAnnotations;
using AbstractFactoryHomework.BMW;
using AbstractFactoryHomework.Lada;

namespace AbstractFactoryHomework
{
    public class Example
    {
        public void Method()
        {
            var ladaFactory = new LadaCarFactory();
            var lada = Car.CreateCar(ladaFactory);

            var bmwFactory = new BmwCarFactory();
            var bmw = Car.CreateCar(bmwFactory);
        }
    }
}