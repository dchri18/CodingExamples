using ChainOfResponsibility.Example.Enums;

namespace ChainOfResponsibility.Example.Loggers
{
    public class InfoLogger : Logger
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.Info;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Info: " + message);
        }
    }
}
