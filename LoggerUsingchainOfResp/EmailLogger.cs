public class EmailLogger : Logger
{
    public EmailLogger()
    {
        SetValidLogLevel(LogLevel.FATAL); // EmailLogger can log FATAL level only
    }

    public override void Log(string message, LogLevel level)
    {
        
        if (level >= ValidLogLevel)
        {
            Console.WriteLine("Logging to email: " + level.ToString() + ": " + message);
            // Simulate sending an email for critical logs
            Console.WriteLine($"Sent email: {level.ToString()}: {message}");
        }

        if (NextLogger != null)
        {
            NextLogger.Log(message, level);
        }
    }
}
