using System;

namespace Core.IoC
{
    /// <summary>
    /// A generic abstraction of an IoC container mechanism
    /// </summary>
    public interface IIoCContainer
    {
        /// <summary>
        /// Global settings to be used by the IoC container
        /// </summary>
        IoCContainerSettings Settings { get; set; }

        /// <summary>
        /// Registers the IoC container mapping from a generic service to a concrete implementation
        /// </summary>
        /// <typeparam name="TService">The generic service interface</typeparam>
        /// <typeparam name="TImplementation">The concrete implementation</typeparam>
        /// <param name="ioCContainerSettings">Optional; will override the Settings property for this registration only</param>
        /// <returns>The instance of this IIoCContainer, to support a fluent API</returns>
        IIoCContainer Register<TService, TImplementation>(IoCContainerSettings ioCContainerSettings = null) where TService : class where TImplementation : TService;

        /// <summary>
        /// Registers the IoC container mapping from a generic service to a concrete implementation
        /// </summary>
        /// <param name="serviceType">Type of the generic service interface</param>
        /// <param name="implementationType">Type of the concrete implementation</param>
        /// <param name="ioCContainerSettings">Optional; will override the Settings property for this registration only</param>
        /// <returns>The instance of this IIoCContainer, to support a fluent API</returns>
        IIoCContainer Register(Type serviceType, Type implementationType, IoCContainerSettings ioCContainerSettings = null);

        /// <summary>
        /// Registers the IoC container mapping from a generic service to a concrete implementation
        /// </summary>
        /// <typeparam name="TService">The generic service interface</typeparam>
        /// <param name="instance">The instance to map the generic service to</param>
        /// <param name="ioCContainerSettings">Optional; will override the Settings property for this registration only</param>
        /// <returns>The instance of this IIoCContainer, to support a fluent API</returns>
        IIoCContainer Register<TService>(TService instance, IoCContainerSettings ioCContainerSettings = null) where TService : class;

        /// <summary>
        /// Resolves a generic service to a concrete implementation using the mapping specified by the given IoC container
        /// </summary>
        /// <typeparam name="TService">The generic service interface</typeparam>
        /// <returns>An instance of the concrete implementation mapped to the generic service</returns>
        TService Resolve<TService>();

        /// <summary>
        /// Frees up the memory being used by any object that was manually resolved from the IoC container
        /// </summary>
        /// <param name="instance">The instance of the object that was returned by the Resolve() method</param>
        /// <remarks>This method does not need to be used on objects that where created by way of the IoC application framework (i.e. the object was initialized by constructor or property injection)</remarks>
        void Release(object instance);

        /// <summary>
        /// Installs any <see cref="IIoCContainerPlugin"/> on the given IoC container
        /// </summary>
        /// <typeparam name="IIoCContainerPlugin">The plugin type to install</typeparam>
        /// <returns>The instance of this IIoCContainer, to support a fluent API</returns>
        IIoCContainer Install<IIoCContainerPlugin>();

        /// <summary>
        /// Indicates to consumers whether or not a generic service is already registered with the IoC container
        /// </summary>
        /// <typeparam name="TService">The generic service interface</typeparam>
        /// <returns>Returns <c>true</c> if the given generic service is already registered with the IoC container; otherwise, <c>false</c></returns>
        bool IsRegistered<TService>();

        /// <summary>
        /// Returns a formatted string that lists out the contents of the IoC container
        /// </summary>
        /// <returns>A formatted string that lists out the contents of the IoC container</returns>
        string ToString();
    }
}
