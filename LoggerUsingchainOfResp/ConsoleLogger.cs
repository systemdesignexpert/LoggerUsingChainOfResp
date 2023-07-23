using System;

public class ConsoleLogger : Logger
{
    public ConsoleLogger()
    {
        SetValidLogLevel(LogLevel.INFO); // ConsoleLogger can log all levels
    }

    public override void Log(string message, LogLevel level)
    {
        
        if (level >= ValidLogLevel)
        {
            Console.WriteLine("Logging to console: " + level.ToString() + ": " + message);
            Console.WriteLine($"{level.ToString()}: {message}");
        }

        if (NextLogger != null)
        {
            NextLogger.Log(message, level);
        }
    }
}
