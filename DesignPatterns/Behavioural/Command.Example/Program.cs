using Command.Example.Commands;
using Command.Example.Components;

namespace Command.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create receiver objects
            Light livingRoomLight = new Light();
            Thermostat thermostat = new Thermostat();

            // Create command objects
            ICommand lightOnCommand = new LightOnCommand(livingRoomLight);
            ICommand lightOffCommand = new LightOffCommand(livingRoomLight);
            ICommand setThermostatCommand = new SetThermostatCommand(thermostat, 22);

            // Create invoker
            RemoteControl remoteControl = new RemoteControl();

            // Set commands
            remoteControl.SetCommand("A", lightOnCommand);
            remoteControl.SetCommand("B", lightOffCommand);
            remoteControl.SetCommand("C", setThermostatCommand);

            // Execute commands
            remoteControl.PressButton("A");
            remoteControl.PressButton("B");
            remoteControl.PressButton("C");
            remoteControl.PressButton("D");  // No command set for this button
        }
    }
}
