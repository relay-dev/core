namespace Core.Framework.Plugins
{
    /// <summary>
    /// Third Party modules that enjoy a pub/sub pattern
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Loads the IPlugin
        /// </summary>
        PluginBuilder Load(PluginContext context);
    }
}
