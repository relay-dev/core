using System;
using Core.Framework;

namespace Core.Application
{
    /// <summary>
    /// Communicates details about the application context
    /// </summary>
    public class ApplicationContext : IContext
    {
        /// <summary>
        /// Constriuctor
        /// </summary>
        public ApplicationContext(long applicationID, string applicationName, string applicationVersion, bool isDebugMode, DateTime buildTimestamp, HostEnvironment hostEnvironment)
        {
            ApplicationID = applicationID;
            ApplicationName = applicationName;
            ApplicationVersion = applicationVersion;
            IsDebugMode = isDebugMode;
            BuildTimestamp = buildTimestamp;
            HostEnvironment = hostEnvironment;
        }

        /// <summary>
        /// The unique Id of the application
        /// </summary>
        public long ApplicationID { get; }

        /// <summary>
        /// The name of the application
        /// </summary>
        public string ApplicationName { get; }

        /// <summary>
        /// The version of the application
        /// </summary>
        public string ApplicationVersion { get; }

        /// <summary>
        /// Indicates whether the application is running in a debugging context
        /// </summary>
        public bool IsDebugMode { get; }

        /// <summary>
        /// The timestamp at which this application was built
        /// </summary>
        public DateTime BuildTimestamp { get; }

        /// <summary>
        /// The HostEnvironment where the application is running (Dev, Test, Stage, Production)
        /// </summary>
        public HostEnvironment HostEnvironment { get; }
    }
}
