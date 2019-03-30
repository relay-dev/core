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
        /// <param name="logEntry">The <see cref="LogEntry"/> to be persisted</param>
        /// <returns>A unique identifier of the persisted <see cref="LogEntry"/></returns>
        string Log(LogEntry logEntry);

        /// <summary>
        /// Logs an informative message, such as Application Startup Time or Application Version
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="args">Optional; a set of objects to be used in a String.Format() to replace any tokens in the message string</param>
        /// <returns>A unique identifier of the persisted <see cref="LogEntry"/></returns>
        string LogInfo(string message, params object[] args);

        /// <summary>
        /// Logs a Warning message
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="args">Optional; a set of objects to be used in a String.Format() to replace any tokens in the message string</param>
        /// <returns>A unique identifier of the persisted <see cref="LogEntry"/></returns>
        string LogWarning(string message, params object[] args);

        /// <summary>
        /// Logs an error; if you have more details to provide, please use the Log(LogEntry logEntry) method
        /// </summary>
        /// <param name="e">The exception</param>
        /// <param name="message">The message to log</param>
        /// <param name="args">Optional; a set of objects to be used in a String.Format() to replace any tokens in the message string</param>
        /// <returns>A unique identifier of the persisted <see cref="LogEntry"/></returns>
        string LogError(Exception e, string message, params object[] args);

        /// <summary>
        /// Logs an error as being fatal; if you have more details to provide, please use the Log(LogEntry logEntry) method
        /// </summary>
        /// <param name="e">The exception</param>
        /// <param name="message">The message to log</param>
        /// <param name="args">Optional; a set of objects to be used in a String.Format() to replace any tokens in the message string</param>
        /// <returns>A unique identifier of the persisted <see cref="LogEntry"/></returns>
        string LogFatal(Exception e, string message, params object[] args);
    }
}
