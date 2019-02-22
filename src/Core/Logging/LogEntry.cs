using Core.Data.Entity;
using System;

namespace Core.Logging
{
    /// <summary>
    /// A generic representation of an entry in a log
    /// </summary>
    public class LogEntry : ReadOnlyEntity
    {
        /// <summary>
        /// The unique identifier for this instance
        /// </summary>
        public string GUID { get; set; }

        /// <summary>
        /// The unique identifier for a given process which can be used to tie all LogEntries for a single Process
        /// </summary>
        public string ProcessGUID { get; set; }

        /// <summary>
        /// The Level at which this LogEntry should be logged
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// A four character representation of the type of error that occured
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// A simple message to display in the logs; no formatting is required
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The Exception that occured, if any
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// The name of the Method that was called under the context of the given LogEntry
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// A serialized version of the object used as input to the Method
        /// </summary>
        public string MethodInput { get; set; }

        /// <summary>
        /// A serialized version of the object used as output to the Method
        /// </summary>
        public string MethodOutput { get; set; }

        /// <summary>
        /// The name of the application for which the LogEntry is being generated
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// The name of the child application for which the LogEntry is being generated
        /// </summary>
        public string ChildApplicationName { get; set; }

        /// <summary>
        /// The name of the machine for which the LogEntry is being generated
        /// </summary>
        public string MachineName { get; set; }

        /// <summary>
        /// The IP Address where the LogEntry is being generated
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// Used in conjunction with the ProcessGUID, this can be used to tag which step in the overall process generated this LogEntry
        /// </summary>
        public string ProcessStep { get; set; }

        /// <summary>
        /// Free-form string that facilitates consumers tagging LogEntries for the sake of grouping them later on
        /// </summary>
        public string GenericIdentifier1 { get; set; }

        /// <summary>
        /// The type of free-form string used in GenericIdentifier1
        /// </summary>
        public string GenericIdentifier1Type { get; set; }

        /// <summary>
        /// Free-form string that facilitates consumers tagging LogEntries for the sake of grouping them later on
        /// </summary>
        public string GenericIdentifier2 { get; set; }

        /// <summary>
        /// The type of free-form string used in GenericIdentifier2
        /// </summary>
        public string GenericIdentifier2Type { get; set; }

        /// <summary>
        /// The total number of milliseconds that elapsed within the scope of the operation for which this LogEntry is being generated
        /// </summary>
        public int ElapsedMilliseconds { get; set; }
    }
}
