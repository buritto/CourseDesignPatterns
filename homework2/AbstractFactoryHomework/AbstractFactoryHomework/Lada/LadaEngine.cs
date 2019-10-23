using System;
using AbstractFactoryHomework.AbstractFactory;

namespace AbstractFactoryHomework.Lada
{
    internal class LadaEngine : IEngine
    {
        private Random _random = new Random();
        private bool _working;

        public void Start()
        {
            var rnd = _random.Next(0, 100);
            if (rnd % 3 == 0)
                _working = true;
            _working = false;
        }

        public void Stop()
        {
            var rnd = _random.Next(0, 100);
            if (rnd % 5 == 0)
                _working = false;
            _working = true;
        }
    }
}