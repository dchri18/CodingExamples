using Observer.Example.Interfaces;

namespace Observer.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create subject
            WeatherStation weatherStation = new WeatherStation();

            // Create observers
            IObserver phoneDisplay1 = new PhoneDisplay("User1");
            IObserver phoneDisplay2 = new PhoneDisplay("User2");
            IObserver desktopWidget = new DesktopWidget("User1");

            // Attach observers to the subject
            weatherStation.Attach(phoneDisplay1);
            weatherStation.Attach(phoneDisplay2);
            weatherStation.Attach(desktopWidget);

            // Change the temperature, which will notify observers
            weatherStation.Temperature = 25.0f;
            weatherStation.Temperature = 30.0f;

            // Detach an observer and change the temperature again
            weatherStation.Detach(phoneDisplay1);
            weatherStation.Temperature = 27.0f;
        }
    }
}
