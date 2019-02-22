namespace Core.Logging
{
    /// <summary>
    /// Describes the Level at which an entry should be logged
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Not specified
        /// </summary>
        Undefined,

        /// <summary>
        /// The Debug level designates fine-grained informational events that are most useful to debug an application
        /// </summary>
        Debug,

        /// <summary>
        /// The Info level designates informational messages that highlight the progress of the application at coarse-grained level
        /// </summary>
        Info,

        /// <summary>
        /// The Warn level designates potentially harmful situations
        /// </summary>
        Warn,

        /// <summary>
        /// The Error level designates error events that might still allow the application to continue running
        /// </summary>
        Error,

        /// <summary>
        /// The Fatal level designates very severe error events that will presumably lead the application to abort
        /// </summary>
        Fatal
    }
}
