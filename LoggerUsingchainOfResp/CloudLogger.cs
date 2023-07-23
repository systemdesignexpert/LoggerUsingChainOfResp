public class CloudLogger : Logger
{
    public CloudLogger()
    {
        SetValidLogLevel(LogLevel.ERROR); // CloudLogger can log FATAL level only
    }

    public override void Log(string message, LogLevel level)
    {
        
        if (level >= ValidLogLevel)
        {
            Console.WriteLine("Logging to cloud: " + level.ToString() + ": " + message);
            // Simulate logging to the cloud
            Console.WriteLine($"Logged to cloud: {level.ToString()}: {message}");
        }

        if (NextLogger != null)
        {
            NextLogger.Log(message, level);
        }
    }
}
