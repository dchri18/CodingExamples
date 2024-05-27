using Observer.Example.Interfaces;

namespace Observer.Example
{
    public class DesktopWidget : IObserver
    {
        private readonly string _name;

        public DesktopWidget(string name)
        {
            _name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} Desktop Widget: Temperature updated to {temperature}°C");
        }
    }
}
