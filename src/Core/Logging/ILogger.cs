using System;

namespace Core.Logging
{
    /// <summary>
    /// A generic abstraction of a logging mechanism
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs an entry in the appropriate Log. This also provides full access to the LogEntry fields
        /// </summary>
        string Log(LogEntry logEntry);

        /// <summary>
        /// Logs an informative message, such as Application Startup Time or Application Version
        /// </summary>
        string LogInfo(string message, params object[] args);

        /// <summary>
        /// Logs a Warning message
        /// </summary>
        string LogWarning(string message, params object[] args);

        /// <summary>
        /// Logs an error; if you have more details to provide, please use the Log(LogEntry logEntry) method
        /// </summary>
        string LogError(Exception e, string message, params object[] args);

        /// <summary>
        /// Logs an error as being fatal; if you have more details to provide, please use the Log(LogEntry logEntry) method
        /// </summary>
        string LogFatal(Exception e, string message, params object[] args);
    }
}
