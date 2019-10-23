using AbstractFactoryHomework.AbstractFactory;

namespace AbstractFactoryHomework.BMW
{
    internal class BmwEngine : IEngine
    {
        private bool _working;

        public void Start()
        {
            _working = true;
        }

        public void Stop()
        {
            _working = false;
        }
    }
}