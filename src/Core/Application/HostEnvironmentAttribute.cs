using System;

namespace Core.Application
{
    /// <summary>
    /// This attribute give you the ability to provide additional meta-data details for a specific value in any Enum that represents runtime Environments
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class HostEnvironmentAttribute : Attribute
    {
        /// <summary>
        /// Returns <c>true</c> if the given EnvironmentCode represents a Mocked runtime Environment; otherwise, <c>false</c>
        /// </summary>
        public bool IsMockInstance { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the given EnvironmentCode represents a Development runtime Environment; otherwise, <c>false</c>
        /// </summary>
        public bool IsDevelopmentInstance { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the given EnvironmentCode represents a Testing runtime Environment; otherwise, <c>false</c>
        /// </summary>
        public bool IsTestingInstance { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the given EnvironmentCode represents a Beta runtime Environment; otherwise, <c>false</c>
        /// </summary>
        public bool IsBetaInstance { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the given EnvironmentCode represents a Production runtime Environment; otherwise, <c>false</c>
        /// </summary>
        public bool IsProductionInstance { get; set; }
    }
}
