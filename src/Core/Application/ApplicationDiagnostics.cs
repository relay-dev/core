using System;

namespace Core.Application
{
    /// <summary>
    /// Encapsulates fields useful when diagnosing an application
    /// </summary>
    public class ApplicationDiagnostics
    {
        /// <summary>
        /// The unique Id of the application
        /// </summary>
        public long ApplicationId { get; set; }

        /// <summary>
        /// The name of the application
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// The version of the application
        /// </summary>
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// The timestamp at which this application was built
        /// </summary>
        public DateTime BuildTimestamp { get; set; }
    }
}
