using Core.Framework.Attributes;

namespace Core.IoC.Plugins
{
    /// <summary>
    /// Provides the ability to provide meta-data for plugins, which allows you to specifiy a plugin's name and type on the IPlugin class
    /// </summary>
    public sealed class IoCContainerPluginAttribute : PluginAttribute
    {
        /// <summary>
        /// Specifies the type of plugin this class represents. This will be used in the IoC auto-wiring process as a key for consuming applications to dictate which modules they're composed of
        /// </summary>
        public string Type { get; set; }
    }
}
