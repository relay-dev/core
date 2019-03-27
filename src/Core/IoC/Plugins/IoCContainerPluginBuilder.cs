using Core.Framework.Plugins;
using System;

namespace Core.IoC.Plugins
{
    /// <summary>
    /// Provides the ability to return an expression back to the framework to be used when registering services with the IoC container
    /// </summary>
    public class IoCContainerPluginBuilder : PluginBuilder
    {
        /// <summary>
        /// Executed before the installation process beings
        /// </summary>
        public Action<IIoCContainer> DeferredBeforeInstall;

        /// <summary>
        /// Executed to run the installation process
        /// </summary>
        public Action<IIoCContainer> DeferredInstall;

        /// <summary>
        /// Executed byfore the installation process beings
        /// </summary>
        public Action<IIoCContainer> DeferredAfterInstall;

        /// <summary>
        /// A deffered action to be run before the plugin is installed
        /// </summary>
        /// <param name="beforeInstall">The deferred action</param>
        /// <returns>The plugin builder expression</returns>
        public IoCContainerPluginBuilder BeforeInstall(Action<IIoCContainer> beforeInstall)
        {
            DeferredBeforeInstall = beforeInstall;

            return this;
        }

        /// <summary>
        /// Given an IIoCContainer, this allows consumers to specify type registraions, etc
        /// </summary>
        /// <param name="onInstall">The deferred action</param>
        /// <returns>The plugin builder expression</returns>
        public IoCContainerPluginBuilder OnInstall(Action<IIoCContainer> onInstall)
        {
            DeferredInstall = onInstall;

            return this;
        }

        /// <summary>
        /// A deffered action to be run after the plugin is installed
        /// </summary>
        /// <param name="afterInstall">The deferred action</param>
        /// <returns>The plugin builder expression</returns>
        public IoCContainerPluginBuilder AfterInstall(Action<IIoCContainer> afterInstall)
        {
            DeferredAfterInstall = afterInstall;

            return this;
        }
    }
}
