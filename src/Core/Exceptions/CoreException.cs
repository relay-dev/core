using System;

namespace Core.Exceptions
{
    /// <summary>
    /// CoreExceptions a thrown only by the Core.* assemblies. There are several overloads to support concise client code.
    /// </summary>
    public class CoreException : Exception
    {
        /// <summary>
        /// The Level at which an entry should be logged
        /// </summary>
        public string LogLevel { get; protected set; }

        /// <summary>
        /// Error Code string to be logged; Error Codes can be found in Core.Constants.ErrorCode.*
        /// </summary>
        public string ErrorCode { get; protected set; }

        /// <summary>
        /// Simple overload for providing a message as part of the exception
        /// </summary>
        /// <param name="message">A brief description of what the LogEntry is. This is not meant to be formatted in a specific way and is not intended to be search on. It's a human-readable descriptive note of what happened. There are other classes for providing more structure to log entries for the sake of searching and grouping</param>
        public CoreException(string message) : base(message)
        {
            ErrorCode = Exceptions.ErrorCode.CORE;
            LogLevel = "Error";
        }

        /// <summary>
        /// Simple overload for providing an <see cref="ErrorCode"/> as well as a message as part of the exception
        /// </summary>
        /// <param name="errorCode">The Error Code string to be logged; Error Codes can be found in Core.Constants.ErrorCode.* and are 4 character strings</param>
        /// <param name="message">A brief description of the LogEntry. This is not meant to be formatted in a specific way and is not intended to be search on. It's a human-readable descriptive note of what happened. There are other classes (i.e. LogEntry) for providing more structure to log entries for the sake of searching and grouping</param>
        public CoreException(string errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
            LogLevel = "Error";
        }

        /// <summary>
        /// Simple overload for providing an inner exception as well as a message as part of the exception
        /// </summary>
        /// <param name="innerException">The inner exception being wrapped</param>
        /// <param name="message">A brief description of what the LogEntry is. This is not meant to be formatted in a specific way and is not intended to be search on. It's a human-readable descriptive note of what happened. There are other classes for providing more structure to log entries for the sake of searching and grouping</param>
        public CoreException(Exception innerException, string message) : base(message, innerException)
        {
            ErrorCode = Exceptions.ErrorCode.CORE;
            LogLevel = "Error";
        }

        /// <summary>
        /// Simple overload for providing an inner exception and an <see cref="Exceptions.ErrorCode"/>, as well as a message as part of the exception
        /// </summary>
        /// <param name="innerException">The inner exception being wrapped</param>
        /// <param name="errorCode">The Error Code string to be logged; Error Codes can be found in Core.Constants.ErrorCode.* and are 4 character strings</param>
        /// <param name="message">A brief description of what the LogEntry is. This is not meant to be formatted in a specific way and is not intended to be search on. It's a human-readable descriptive note of what happened. There are other classes (i.e. LogEntry) for providing more structure to log entries for the sake of searching and grouping</param>
        public CoreException(Exception innerException, string errorCode, string message) : base(message, innerException)
        {
            ErrorCode = errorCode;
            LogLevel = "Error";
        }
    }
}
