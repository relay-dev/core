using System;

namespace Core.IoC
{
    /// <summary>
    /// Provides the ability to provide meta-data for plugins, which allows you to specifiy a plugin's name and type on the IPlugin class
    /// </summary>
    public sealed class IoCContainerAttribute : Attribute
    {
        /// <summary>
        /// Specifies the type of plugin this class represents. This will be used in the IoC auto-wiring process as a key for consuming applications to dictate which modules they're composed of
        /// </summary>
        public string Name { get; set; }
    }
}
