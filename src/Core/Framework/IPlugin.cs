using Core.Framework.Plugins;

namespace Core.Framework
{
    /// <summary>
    /// Third-party plugins and non-third-party implementations that enjoy a pub/sub pattern
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Loads the IPlugin
        /// </summary>
        PluginBuilder Load(PluginContext context);
    }
}
