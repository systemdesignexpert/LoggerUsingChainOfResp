public class LoggerChainBuilder
{
    public Logger Build()
    {
        Logger consoleLogger = new ConsoleLogger();
        Logger fileLogger = new FileLogger();
        Logger cloudLogger = new CloudLogger();
        Logger emailLogger = new EmailLogger();

        // Chain the loggers
        consoleLogger.SetNextLogger(fileLogger);
        fileLogger.SetNextLogger(cloudLogger);
        cloudLogger.SetNextLogger(emailLogger);

        return consoleLogger;
    }
}
