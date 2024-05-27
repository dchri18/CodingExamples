using ChainOfResponsibility.Example.Enums;

namespace ChainOfResponsibility.Example.Loggers
{
    public class DebugLogger : Logger
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.Debug;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Debug: " + message);
        }
    }
}
