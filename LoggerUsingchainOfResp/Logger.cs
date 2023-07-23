// Handler interface
public abstract class Logger
{
    protected Logger NextLogger;
    protected LogLevel ValidLogLevel;

    public void SetNextLogger(Logger nextLogger)
    {
        NextLogger = nextLogger;
    }

    public void SetValidLogLevel(LogLevel logLevel)
    {
        ValidLogLevel = logLevel;
    }

    public abstract void Log(string message, LogLevel level);
}
