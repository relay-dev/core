using Core.Framework;
using System;
using System.IO;

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
        /// Constructor
        /// </summary>
        public ApplicationContext(
            string applicationName,
            Type typeFromAssembly,
            long applicationId = 0,
            string applicationVersion = "")
        {
            ApplicationName = applicationName;
            ApplicationId = applicationId;
            ApplicationVersion = applicationVersion;
            BuildTimestamp = GetBuildTimestamp(typeFromAssembly);
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

        private static DateTime GetBuildTimestamp(Type type)
        {
            const int peHeaderOffset = 60;
            const int linkerTimestampOffset = 8;
            var bytes = new byte[2048];

            using (var file = new FileStream(type.Assembly.Location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                file.Read(bytes, 0, bytes.Length);
            }

            var headerPos = BitConverter.ToInt32(bytes, peHeaderOffset);
            var secondsSince1970 = BitConverter.ToInt32(bytes, headerPos + linkerTimestampOffset);
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var linkTimeUtc = dt.AddSeconds(secondsSince1970);

            return TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, TimeZoneInfo.Local);
        }
    }
}
