using System.IO;

public class FileLogger : Logger
{
    private readonly string filePath = "../../../log.txt";

    public FileLogger()
    {
        SetValidLogLevel(LogLevel.WARNING); // FileLogger can log ERROR and FATAL levels
    }

    public override void Log(string message, LogLevel level)
    {

        
        if (level >= ValidLogLevel)
        {
            Console.WriteLine("Logging to file: " + level.ToString() + ": " + message);
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"{level.ToString()}: {message}");
            }
        }

        if (NextLogger != null)
        {
            NextLogger.Log(message, level);
        }
    }
}
