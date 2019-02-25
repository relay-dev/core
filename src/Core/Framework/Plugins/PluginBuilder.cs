using Core.IoC;
using System;

namespace Core.Framework.Plugins
{
    /// <summary>
    /// Provides the ability for consumers to return an expression back to the framework to be used when registering services with the IoC container
    /// </summary>
    public class PluginBuilder
    {
        /// <summary>
        /// Given an IIoCContainer, this allows consumers to specify type registraions, etc
        /// </summary>
        public Action<IIoCContainer> IoCContainer { get; set; }
    }
}
