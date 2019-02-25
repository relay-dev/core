using System;

namespace Core.Framework.Attributes
{
    /// <summary>
    /// This attribute give you the ability to create new Components and subscribe them to existing Modules without impacting Module code (i.e. this facilitaes a loose coupling between Modules and Components)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class ComponentAttribute : Attribute
    {
        /// <summary>
        /// The name of this Component
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of this Component
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The Plugin this Component should be associated with
        /// </summary>
        public string PluginName { get; set; }
    }
}
