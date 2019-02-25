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
        /// The unique Id of the application
        /// </summary>
        long ApplicationID { get; }

        /// <summary>
        /// The name of the application
        /// </summary>
        string ApplicationName { get; }

        /// <summary>
        /// The version of the application
        /// </summary>
        string ApplicationVersion { get; }

        /// <summary>
        /// Indicates whether the application is running in a debugging context
        /// </summary>
        bool IsDebugMode { get; }
        
        /// <summary>
        /// The timestamp at which this application was built
        /// </summary>
        DateTime BuildTimestamp { get; }

        /// <summary>
        /// The HostEnvironment where the application is running (Dev, Test, Stage, Production)
        /// </summary>
        HostEnvironment HostEnvironment { get; }
    }
}
