using Core.Framework.Plugins;
using System;

namespace Core.IoC.Plugins
{
    /// <summary>
    /// Provides the ability to return an expression back to the framework to be used when registering services with the IoC container
    /// </summary>
    public class IoCContainerPluginBuilder : PluginBuilder
    {
        public Action<IIoCContainer> DeferredBeforeInstall;
        public Action<IIoCContainer> DeferredInstall;
        public Action<IIoCContainer> DeferredAfterInstall;
        
        /// <summary>
        /// A defered action to be run before the plugin is installed
        /// </summary>
        public IoCContainerPluginBuilder BeforeInstall(Action<IIoCContainer> beforeInstall)
        {
            DeferredBeforeInstall = beforeInstall;

            return this;
        }

        /// <summary>
        /// Given an IIoCContainer, this allows consumers to specify type registraions, etc
        /// </summary>
        public IoCContainerPluginBuilder OnInstall(Action<IIoCContainer> onInstall)
        {
            DeferredInstall = onInstall;

            return this;
        }

        /// <summary>
        /// A defered action to be run after the plugin is installed
        /// </summary>
        public IoCContainerPluginBuilder AfterInstall(Action<IIoCContainer> afterInstall)
        {
            DeferredAfterInstall = afterInstall;

            return this;
        }
    }
}
