using Command.Example.Commands;

namespace Command.Example
{
    public class RemoteControl
    {
        private readonly Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

        public void SetCommand(string button, ICommand command)
        {
            _commands[button] = command;
        }

        public void PressButton(string button)
        {
            if (_commands.ContainsKey(button))
            {
                _commands[button].Execute();
            }
            else
            {
                Console.WriteLine($"No command set for button {button}");
            }
        }
    }
}
