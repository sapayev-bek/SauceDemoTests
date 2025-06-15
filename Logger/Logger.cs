using log4net;

public static class Logger
{
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Logger));

    public static void Info(string message) => log.Info(message);
    public static void Error(string message) => log.Error(message);
}
