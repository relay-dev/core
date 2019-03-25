﻿namespace Core.Application
{
    /// <summary>
    /// A generic abstraction of an application bootstrapper
    /// </summary>
    public interface IBootstrapper<TInput, TOutput>
    {
        /// <summary>
        /// Called by the Core application framework during application startup
        /// </summary>
        TOutput Startup(TInput input);
    }

    /// <summary>
    /// A generic abstraction of an application bootstrapper
    /// </summary>
    public interface IBootstrapper
    {
        /// <summary>
        /// Called by the Core application framework during application startup
        /// </summary>
        void Startup();
    }
}
