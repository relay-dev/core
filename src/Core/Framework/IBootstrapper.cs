﻿namespace Core.Framework
{
    /// <summary>
    /// A generic abstraction of an application bootstrapper
    /// </summary>
    /// <typeparam name="TInput">The input to the startup process</typeparam>
    /// <typeparam name="TOutput">The output of the startup process</typeparam>
    public interface IBootstrapper<in TInput, out TOutput>
    {
        /// <summary>
        /// Called by the Core application framework during application startup
        /// </summary>
        /// <param name="input">The input to the startup process</param>
        /// <returns>The result of the startup process</returns>
        TOutput Startup(TInput input);
    }

    /// <summary>
    /// A generic abstraction of an application bootstrapper
    /// </summary>
    /// <typeparam name="TOutput">The output of the startup process</typeparam>
    public interface IBootstrapper<out TOutput>
    {
        /// <summary>
        /// Called by the Core application framework during application startup
        /// </summary>
        /// <returns>The result of the startup process</returns>
        TOutput Startup();
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
