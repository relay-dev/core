using Core.Framework.Plugins;
using System;

namespace Core.IoC.Plugins
{
    /// <summary>
    /// Provides the ability to return an expression back to the framework to be used when registering services with the IoC container
    /// </summary>
    public class IoCContainerPluginBuilder : PluginBuilder
    {
        public Action<IIoCContainer> DeferredOnInstall;
        public Action<IIoCContainer> DeferredRegisterServices;
        
        /// <summary>
        /// A defered action to be run when the plugin is installed
        /// </summary>
        public IoCContainerPluginBuilder OnInstall(Action<IIoCContainer> onInstall)
        {
            DeferredOnInstall = onInstall;

            return this;
        }

        /// <summary>
        /// Given an IIoCContainer, this allows consumers to specify type registraions, etc
        /// </summary>
        public IoCContainerPluginBuilder RegisterServices(Action<IIoCContainer> registerServices)
        {
            DeferredRegisterServices = registerServices;

            return this;
        }
    }
}
