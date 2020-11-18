using System;

namespace Core.Framework
{
    /// <summary>
    /// Represents a simple class that runs a process
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ProcessorAttribute : Attribute
    {
        /// <summary>
        /// Specifies the name of the process the class represents
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specifies the category of the process
        /// </summary>
        public string Category { get; set; }
    }
}
