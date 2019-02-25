﻿using Core.Framework;

namespace Core.IoC.Plugins
{
    /// <summary>
    /// Third-party IoCContainer plugins and non-third-party implementations that enjoy a pub/sub pattern
    /// </summary>
    public interface IIoCContainerPlugin : IPlugin
    {
        /// <summary>
        /// Loads the IPlugin
        /// </summary>
        IoCContainerPluginBuilder Load(IoCContainerPluginContext context);
    }
}