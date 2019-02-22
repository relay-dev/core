using System;

namespace Core.Data.Attributes
{
    /// <summary>
    /// This attribute provides the ability to specify meta-data about a Command, such as whether or not it will alter a data source
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class CommandAttribute : Attribute
    {
        /// <summary>
        /// Set to <c>true</c> if the Command you are denoting will alter a data source, such as a database; otherwise, <c>false</c>
        /// </summary>
        public bool IsPersistent { get; set; }
    }
}
