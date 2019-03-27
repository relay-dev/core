using System;

namespace Core.Mapping
{
    /// <summary>
    /// Provides the ability to specify meta-data about a Command, such as whether or not it will alter a data source
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class MapAttribute : Attribute
    {
        /// <summary>
        /// The type which should be mapped from
        /// </summary>
        public Type Source { get; set; }

        /// <summary>
        /// The type which should be mapped to
        /// </summary>
        public Type Destination { get; set; }

        /// <summary>
        /// Optional; allows an application to host n classes that map the same source type to the same destination type, but in different ways
        /// </summary>
        public string ProfileName { get; set; }
    }
}
