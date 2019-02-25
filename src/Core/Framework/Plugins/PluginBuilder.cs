using Core.IoC;
using System;

namespace Core.Framework.Plugins
{
    /// <summary>
    /// Provides the ability for consumers to return an expression back to the framework to be used when registering services with the IoC container
    /// </summary>
    public class PluginBuilder
    {
        public Action<IIoCContainer> DeferredOnInstall;
        public Action<IIoCContainer> DeferredIoCContainer;

        /// <summary>
        /// A defered action to be run when the plugin is installed
        /// </summary>
        public PluginBuilder OnInstall(Action<IIoCContainer> onInstall)
        {
            DeferredOnInstall = onInstall;

            return this;
        }

        /// <summary>
        /// Given an IIoCContainer, this allows consumers to specify type registraions, etc
        /// </summary>
        public PluginBuilder IoCContainer(Action<IIoCContainer> iocContainer)
        {
            DeferredIoCContainer = iocContainer;

            return this;
        }
    }
}
