using ChainOfResponsibility.Example.Enums;

namespace ChainOfResponsibility.Example.Loggers
{
    public class WarnLogger : Logger
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.Warning;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Warning: " + message);
        }
    }
}
