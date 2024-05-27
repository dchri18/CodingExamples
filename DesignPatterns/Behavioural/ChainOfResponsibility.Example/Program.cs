using ChainOfResponsibility.Example.Enums;
using ChainOfResponsibility.Example.Loggers;

namespace ChainOfResponsibility.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the chain of loggers
            Logger errorLogger = new ErrorLogger();
            Logger warnLogger = new WarnLogger();
            Logger infoLogger = new InfoLogger();
            Logger debugLogger = new DebugLogger();

            // Set the chain of responsibility
            debugLogger.SetNextLogger(infoLogger);
            infoLogger.SetNextLogger(warnLogger);
            warnLogger.SetNextLogger(errorLogger);

            // Pass log messages
            debugLogger.LogMessage(LogLevel.Debug, "This is a debug message.");
            debugLogger.LogMessage(LogLevel.Info, "This is an info message.");
            debugLogger.LogMessage(LogLevel.Warning, "This is a warning message.");
            debugLogger.LogMessage(LogLevel.Error, "This is an error message.");

            Console.ReadKey();
        }
    }
}
