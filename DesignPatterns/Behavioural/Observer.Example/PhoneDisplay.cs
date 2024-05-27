using Observer.Example.Interfaces;

namespace Observer.Example
{
    public class PhoneDisplay : IObserver
    {
        private readonly string _name;

        public PhoneDisplay(string name)
        {
            _name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} Phone Display: Temperature updated to {temperature}°C");
        }
    }
}
