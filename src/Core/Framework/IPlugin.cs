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
        /// <param name="context">The overall context of the startup operation so that consumers have some knowledge about the startup process that would otherwise be out of scope</param>
        /// <returns>An expression that can be used as a set of instructions for how to initialize the application properly</returns>
        PluginBuilder Load(PluginContext context);
    }
}
