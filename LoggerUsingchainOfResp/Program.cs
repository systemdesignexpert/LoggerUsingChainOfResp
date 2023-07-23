LoggerChainBuilder builder = new LoggerChainBuilder();
Logger logger = builder.Build();

// Test the logger
logger.Log("This is an informational message.", LogLevel.INFO);
logger.Log("This is a warning message.", LogLevel.WARNING);
logger.Log("This is an error message.", LogLevel.ERROR);
logger.Log("This is a fatal message.", LogLevel.FATAL);