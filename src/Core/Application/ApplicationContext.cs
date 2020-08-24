using Core.Framework;
using System;

namespace Core.Application
{
    /// <summary>
    /// Communicates details about the application context
    /// </summary>
    public class ApplicationContext : IContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ApplicationContext(
            string applicationName = "",
            long applicationId = 0,
            string applicationVersion = "",
            DateTime buildTimestamp = default)
        {
            ApplicationName = applicationName;
            ApplicationId = applicationId;
            ApplicationVersion = applicationVersion;
            BuildTimestamp = buildTimestamp;
        }

        /// <summary>
        /// The unique Id of the application
        /// </summary>
        public long ApplicationId { get; }

        /// <summary>
        /// The name of the application
        /// </summary>
        public string ApplicationName { get; }

        /// <summary>
        /// The version of the application
        /// </summary>
        public string ApplicationVersion { get; }

        /// <summary>
        /// The timestamp at which this application was built
        /// </summary>
        public DateTime BuildTimestamp { get; }
    }
}
