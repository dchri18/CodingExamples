using Observer.Example.Interfaces;

namespace Observer.Example
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private float _temperature;

        public float Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }

}
