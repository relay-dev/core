using System;

namespace Core.Application
{
    /// <summary>
    /// This attribute provides the ability to specify meta-data about an application
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class ApplicationAttribute : Attribute
    {
        /// <summary>
        /// The name of the hosting application
        /// </summary>
        public string Name { get; set; }
    }
}
