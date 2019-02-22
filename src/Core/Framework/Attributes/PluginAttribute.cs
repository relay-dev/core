using System;

namespace Core.Data.Attributes
{
    /// <summary>
    /// This attribute give you the ability to provide meta-data for Plugin modules, which allows you to specifiy a Plugin's name and type on the ICorePlugin class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public sealed class PluginAttribute: Attribute
    {
        /// <summary>
        /// A name that uniquely identifies this module. This will be used in the IoC auto-wiring process as a key for consuming applications to dictate which modules they're composed of
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specifies the type of module this class represents. This will be used in the IoC auto-wiring process as a key for consuming applications to dictate which modules they're composed of
        /// </summary>
        public string Type { get; set; }
    }
}
