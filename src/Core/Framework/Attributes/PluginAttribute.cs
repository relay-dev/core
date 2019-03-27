using System;

namespace Core.Framework.Attributes
{
    /// <summary>
    /// Provides the ability to provide meta-data for plugins, which allows you to specifiy a plugin's name and type on the IPlugin class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public class PluginAttribute: Attribute
    {
        /// <summary>
        /// A name that uniquely identifies this plugin. This will be used in the IoC auto-wiring process as a key for consuming applications to dictate which modules they're composed of
        /// </summary>
        public string Name { get; set; }
    }
}
