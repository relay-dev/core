using Core.Data;

namespace Core.IoC
{
    /// <summary>
    /// A Plugin for <see cref="IIoCContainer"/>
    /// </summary>
    public interface IIoCContainerPlugin : IPlugin
    {
        /// <summary>
        /// Allows IoCContainerPlugins to setup their configurations for the <see cref="IIoCContainer"/>
        /// </summary>
        /// <param name="ioCContainer">The application's IoC container</param>
        void Register(IIoCContainer ioCContainer);
    }
}
