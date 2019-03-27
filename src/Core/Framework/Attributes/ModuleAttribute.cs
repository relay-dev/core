using System;

namespace Core.Framework.Attributes
{
    /// <summary>
    /// Provides you the ability to specify meta-data about your Module, such as a Name
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class ModuleAttribute : Attribute
    {
        /// <summary>
        /// The Name of this Module
        /// </summary>
        public string Name { get; set; }
    }
}
