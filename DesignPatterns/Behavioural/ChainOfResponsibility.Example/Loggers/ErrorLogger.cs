using ChainOfResponsibility.Example.Enums;

namespace ChainOfResponsibility.Example.Loggers
{
    public class ErrorLogger : Logger
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.Error;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Error: " + message);
        }
    }
}
