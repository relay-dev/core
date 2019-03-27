namespace Core.IoC.Plugins
{
    /// <summary>
    /// Third-party IoCContainer plugins and non-third-party implementations that enjoy a pub/sub pattern
    /// </summary>
    public interface IIoCContainerPlugin
    {
        /// <summary>
        /// Loads the IPlugin
        /// </summary>
        /// <param name="context">The overall context of the startup operation so that consumers have some knowledge about the startup process that would otherwise be out of scope</param>
        /// <returns>An expression that can be used as a set of instructions for what to do with an IoC container to install the plugin properly</returns>
        IoCContainerPluginBuilder Load(IoCContainerPluginContext context);
    }
}
