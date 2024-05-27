using ChainOfResponsibility.Example.Enums;

namespace ChainOfResponsibility.Example.Loggers
{
    public abstract class Logger
    {
        protected Logger _nextLogger;

        public void SetNextLogger(Logger nextLogger)
        {
            _nextLogger = nextLogger;
        }

        public void LogMessage(LogLevel level, string message)
        {
            if (CanHandle(level))
            {
                Write(message);
            }
            else if (_nextLogger != null)
            {
                _nextLogger.LogMessage(level, message);
            }
        }

        protected abstract bool CanHandle(LogLevel level);
        protected abstract void Write(string message);
    }
}
