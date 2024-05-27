using Command.Example.Components;

namespace Command.Example.Commands
{
    public class SetThermostatCommand : ICommand
    {
        private readonly Thermostat _thermostat;
        private readonly int _temperature;

        public SetThermostatCommand(Thermostat thermostat, int temperature)
        {
            _thermostat = thermostat;
            _temperature = temperature;
        }

        public void Execute()
        {
            _thermostat.SetTemperature(_temperature);
        }
    }
}
